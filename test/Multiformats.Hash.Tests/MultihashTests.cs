﻿namespace Multiformats.Hash.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryEncoding;
using Multiformats.Base;
using Org.BouncyCastle.Utilities.Encoders;
using Xunit;

public class MultihashTests
{
    [Theory]
    [InlineData("0beec7b5ea3f0fdbc95d0dd47f3c5bc275da8a33", 0x11, "sha1")]
    [InlineData("0beec7b5", 0x11, "sha1")]
    [InlineData("2c26b46b68ffc68ff99b453c1d30413413422d706483bfa0f98a5e886266e7ae", 0x12, "sha2-256")]
    [InlineData("2c26b46b", 0x12, "sha2-256")]
    [InlineData("0beec7b5ea3f0fdbc9", 0xb220, "blake2b-256")]
    public void TestEncode(string hex, int code, string name)
    {
        var ob = Hex.Decode(hex);
        var nb = Binary.Varint.GetBytes((uint)code).Concat(Binary.Varint.GetBytes((uint)ob.Length)).Concat(ob).ToArray();

        var encoded = Multihash.Encode(ob, (HashType)code);

        Assert.Equal(encoded, nb);

        var h = TestCastToMultihash(hex, code, name);
        Assert.Equal((byte[])h, nb);
    }

    private static Multihash TestCastToMultihash(string hex, int code, string name)
    {
        var ob = Hex.Decode(hex);
        var b = Binary.Varint.GetBytes((uint) code).Concat(Binary.Varint.GetBytes((uint) ob.Length)).Concat(ob).ToArray();
        return Multihash.Cast(b);
    }

    [Fact]
    public void CanDecodeFromMultibase()
    {
        var hex = Multibase.Base58.Decode("8Vtkv2tdQ43bNGdWN9vNx9GVS9wrbXHk4ZW8kmucPmaYJwwedXir52kti9wJhcik4HehyqgLrQ1hBuirviLhxgRBNv");
        var mb = Multibase.Base32.Encode(hex);

        Assert.True(Multihash.TryParse(mb, out var mh));
        Assert.Equal(mh.ToBytes(), hex);
    }

    [Fact]
    public void CanDecodeFromMultibaseAndDetectEncoding()
    {
        var hex = Multibase.Base58.Decode("8Vtkv2tdQ43bNGdWN9vNx9GVS9wrbXHk4ZW8kmucPmaYJwwedXir52kti9wJhcik4HehyqgLrQ1hBuirviLhxgRBNv");
        var mb = Multibase.Base32.Encode(hex);

        Assert.True(Multihash.TryParse(mb, out var mh, out var encoding));
        Assert.Equal(mh.ToBytes(), hex);
        Assert.Equal(encoding, MultibaseEncoding.Base32Lower);
    }

    [Fact]
    public void CanDecodeFromMultibaseWithKnownEncoding()
    {
        var hex = Multibase.Base58.Decode("8Vtkv2tdQ43bNGdWN9vNx9GVS9wrbXHk4ZW8kmucPmaYJwwedXir52kti9wJhcik4HehyqgLrQ1hBuirviLhxgRBNv");
        var mb = Multibase.Base32.Encode(hex);

        Assert.True(Multihash.TryParse(mb, MultibaseEncoding.Base32Lower, out var mh));
        Assert.Equal(mh.ToBytes(), hex);
    }

    [Theory]
    [InlineData("2c26b46b68ffc68ff99b453c1d30413413422d706483bfa0f98a5e886266e7ae", 0x00, "id")]
    [InlineData("", 0x00, "id")]
    [InlineData("0beec7b5ea3f0fdbc95d0dd47f3c5bc275da8a33", 0x11, "sha1")]
    [InlineData("0beec7b5", 0x11, "sha1")]
    [InlineData("2c26b46b68ffc68ff99b453c1d30413413422d706483bfa0f98a5e886266e7ae", 0x12, "sha2-256")]
    [InlineData("2c26b46b", 0x12, "sha2-256")]
    [InlineData("0beec7b5ea3f0fdbc9", 0xb220, "blake2b-256")]
    public void TestDecode(string hex, int code, string name)
    {
        var ob = Hex.Decode(hex);
        var nb = Binary.Varint.GetBytes((uint)code).Concat(Binary.Varint.GetBytes((uint)ob.Length)).Concat(ob).ToArray();

        var dec = Multihash.Decode(nb);
        Assert.Equal((int)dec.Code, code);
        Assert.Equal(dec.Name, name);
        Assert.Equal(dec.Length, ob.Length);
        Assert.Equal(dec.Digest, ob);
    }

    public static IEnumerable<object[]> GetSupportedHashTable() => Multihash.SupportedHashCodes.Select(h => new object[] { (int)h, Multihash.GetName(h) });

    [Theory]
    [MemberData(nameof(GetSupportedHashTable), DisableDiscoveryEnumeration = false)]
    public void TestTable(int code, string name)
    {
        if (Multihash.GetName(code) != name)
            Assert.True(false, $"Table mismatch: {Multihash.GetName(code)}, {name}");

        if ((int)Multihash.GetCode(name) != code)
            Assert.True(false, $"Table mismatch: {Multihash.GetCode(name)}, {code}");
    }

    [Theory]
    [InlineData("5drNu81uhrFLRiS4bxWgAkpydaLUPW", "hello world")] // sha1
    [InlineData("QmaozNR7DZHQK1ZcU9p7QdrshMvXqWK6gpu5rmrkPdT3L4", "hello world")] // sha2_256
    [InlineData("8Vtkv2tdQ43bNGdWN9vNx9GVS9wrbXHk4ZW8kmucPmaYJwwedXir52kti9wJhcik4HehyqgLrQ1hBuirviLhxgRBNv", "hello world")] // sha2_512
    [InlineData("8tWhXW5oUwtPd9d3FnjuLP1NozN3vc45rmsoWEEfrZL1L6gi9dqi1YkZu5iHb2HJ8WbZaaKAyNWWRAa8yaxMkGKJmX", "hello world")] // sha3_512
    public void TestVerify(string mhs, string data)
    {
        var mh = Multihash.Parse(mhs);
        var bytes = Encoding.UTF8.GetBytes(data);

        Assert.True(mh.Verify(bytes));
    }

    public static IEnumerable<object[]> GetSupportedHashes() => Multihash.SupportedHashCodes.Select(h => new object[] { h });

    [Theory]
    [MemberData(nameof(GetSupportedHashes), DisableDiscoveryEnumeration = false)]
    public void VerifyRoundTrip(HashType type)
    {
        var rand = new Random(Environment.TickCount);
        var bytes = new byte[rand.Next(1024, 4096)];
        rand.NextBytes(bytes);

        var mh = Multihash.Sum(type, bytes, type == HashType.ID ? bytes.Length : -1);
        var str = mh.ToString();
        var mh2 = Multihash.Parse(str);

        Assert.True(mh2.Verify(bytes));
    }

    [Theory]
    [MemberData(nameof(GetSupportedHashes), DisableDiscoveryEnumeration = false)]
    public async Task VerifyRoundTripAsync(HashType type)
    {
        var rand = new Random(Environment.TickCount);
        var bytes = new byte[rand.Next(1024, 4096)];
        rand.NextBytes(bytes);

        var mh = await Multihash.SumAsync(type, bytes, type == HashType.ID ? bytes.Length : -1);
        var str = mh.ToString();
        var mh2 = Multihash.Parse(str);

        Assert.True(await mh2.VerifyAsync(bytes));
    }

    [Theory]
    [MemberData(nameof(GetSupportedHashes), DisableDiscoveryEnumeration = false)]
    public void TestMultithreadedEnvironment(HashType type)
    {
        var rand = new Random(Environment.TickCount);
        var bytes = new byte[32*1024];
        rand.NextBytes(bytes);

        Parallel.For(0, 200, _ => Multihash.Sum(type, bytes));
    }
}
