namespace Multiformats.Hash;

using BinaryEncoding;
using Multiformats.Base;
using Multiformats.Hash.Algorithms;
using System;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// The multihash class
/// </summary>
public class Multihash
{
    private static readonly MultibaseEncoding[] _encodings =
    {
        MultibaseEncoding.Base16Lower,
        MultibaseEncoding.Base32Lower,
        MultibaseEncoding.Base58Btc,
        MultibaseEncoding.Base64,
        MultibaseEncoding.Base2,
        MultibaseEncoding.Base8,
    };

    private static readonly Registry _registry = new();

    private readonly Lazy<byte[]> _bytes;

    /// <summary>
    /// Initializes a new instance of the <see cref="Multihash"/> class.
    /// </summary>
    /// <param name="bytes">The bytes.</param>
    protected Multihash(byte[] bytes)
    {
        _bytes = new Lazy<byte[]>(() => bytes);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Multihash"/> class.
    /// </summary>
    /// <param name="code">The code.</param>
    /// <param name="digest">The digest.</param>
    protected Multihash(HashType code, byte[] digest)
    {
        Code = code;
        Name = GetName((int)code);
        Digest = digest;

        _bytes = new Lazy<byte[]>(() => Encode(digest, code));
    }

    /// <summary>
    /// Gets the supported hash codes.
    /// </summary>
    /// <value>
    /// The supported hash codes.
    /// </value>
    public static HashType[] SupportedHashCodes => _registry.SupportedHashTypes;

    /// <summary>
    /// Gets the code.
    /// </summary>
    /// <value>
    /// The code.
    /// </value>
    public HashType Code { get; }

    /// <summary>
    /// Gets the digest.
    /// </summary>
    /// <value>
    /// The digest.
    /// </value>
    public byte[] Digest { get; }

    /// <summary>
    /// Gets the length.
    /// </summary>
    /// <value>
    /// The length.
    /// </value>
    public int Length => Digest?.Length ?? 0;

    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name { get; }

    /// <summary>Casts the specified buf.</summary>
    /// <param name="buf">The buf.</param>
    /// <returns></returns>
    public static Multihash Cast(byte[] buf) => Decode(buf);

    /// <summary>Decodes the specified buf.</summary>
    /// <param name="buf">The buf.</param>
    /// <returns></returns>
    /// <exception cref="System.ArgumentNullException">buf</exception>
    /// <exception cref="System.Exception">
    /// Too short
    /// or
    /// Incosistent length
    /// </exception>
    public static Multihash Decode(byte[] buf)
    {
        if (buf is null)
        {
            throw new ArgumentNullException(nameof(buf));
        }

        if (buf.Length < 2)
        {
            throw new Exception("Too short");
        }

        var offset = Binary.Varint.Read(buf, 0, out uint code);
        offset += Binary.Varint.Read(buf, offset, out uint length);

        return length > buf.Length - offset
            ? throw new Exception("Incosistent length")
            : new Multihash((HashType)code, buf.Slice(offset));
    }

    /// <summary>Encodes the specified data.</summary>
    /// <param name="data">The data.</param>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static byte[] Encode(byte[] data, HashType code) => Binary.Varint.GetBytes((uint)code).Concat(Binary.Varint.GetBytes((uint)data.Length), data);

    /// <summary>Encodes the specified s.</summary>
    /// <param name="s">The s.</param>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static Multihash Encode(string s, HashType code) => Encode(Multibase.Base32.Decode(s), code);

    /// <summary>Encodes the specified data.</summary>
    /// <typeparam name="TAlgorithm">The type of the algorithm.</typeparam>
    /// <param name="data">The data.</param>
    /// <returns></returns>
    /// <exception cref="System.NotSupportedException"></exception>
    public static byte[] Encode<TAlgorithm>(byte[] data) where TAlgorithm : IMultihashAlgorithm
    {
        var algo = Registry.GetHashType<TAlgorithm>();
        return algo.HasValue
            ? Binary.Varint.GetBytes((uint)algo.Value).Concat(Binary.Varint.GetBytes((uint)data.Length), data)
            : throw new NotSupportedException($"{typeof(TAlgorithm)} is not supported.");
    }

    /// <summary>Returns a multihash from the B58 string.</summary>
    /// <param name="s">The B58 string.</param>
    /// <returns>The multihash.</returns>
    [Obsolete("Use Parse/TryParse instead")]
    public static Multihash FromB58String(string s) => Cast(Multibase.Base58.Decode(s));

    /// <summary>Returns a multihash from the hexadecimal string.</summary>
    /// <param name="s">The hexadecimal string.</param>
    /// <returns>The multihash.</returns>
    [Obsolete("Use Parse/TryParse instead")]
    public static Multihash FromHexString(string s) => Cast(Multibase.Base16.Decode(s));

    /// <summary>Gets the code.</summary>
    /// <param name="name">The name.</param>
    /// <returns>The hash type.</returns>
    public static HashType? GetCode(string name) => Enum.TryParse(name.Replace("-", "_"), true, out HashType result) ? result : new HashType?();

    /// <summary>Gets the name.</summary>
    /// <param name="code">The code.</param>
    /// <returns>The name.</returns>
    public static string GetName(HashType code) => code.ToString().Replace("_", "-").ToLower();

    /// <summary>Gets the name.</summary>
    /// <param name="code">The code.</param>
    /// <returns>The name.</returns>
    public static string GetName(int code) => Enum.IsDefined(typeof(HashType), (HashType)code) ? GetName((HashType)code) : "unsupported";

    /// <summary>
    /// Performs an implicit conversion from <see cref="Multihash"/> to <see cref="byte[]"/>.
    /// </summary>
    /// <param name="mh">The multihash.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator byte[](Multihash mh) => mh._bytes.Value;

    /// <summary>
    /// Performs an implicit conversion from <see cref="byte[]"/> to <see cref="Multihash"/>.
    /// </summary>
    /// <param name="buf">The buffer.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Multihash(byte[] buf) => Decode(buf);

    /// <summary>
    /// Performs an implicit conversion from <see cref="string"/> to <see cref="Multihash"/>.
    /// </summary>
    /// <param name="s">The string.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Multihash(string s) => Parse(s);

    /// <summary>
    /// Performs an implicit conversion from <see cref="Multihash"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="mh">The multihash.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator string(Multihash mh) => mh.ToString(MultibaseEncoding.Base16Lower);

    /// <summary>Parses the specified s.</summary>
    /// <param name="s">The s.</param>
    /// <returns></returns>
    /// <exception cref="System.FormatException">Not a valid multihash</exception>
    public static Multihash Parse(string s)
    {
        return !TryParse(s, out var mh) ? throw new FormatException("Not a valid multihash") : mh;
    }

    /// <summary>Parses the specified s.</summary>
    /// <param name="s">The s.</param>
    /// <param name="encoding">The encoding.</param>
    /// <returns></returns>
    /// <exception cref="System.FormatException">Not a valid multihash</exception>
    public static Multihash Parse(string s, MultibaseEncoding encoding)
    {
        return !TryParse(s, encoding, out var mh) ? throw new FormatException("Not a valid multihash") : mh;
    }

    /// <summary>Sums the specified code.</summary>
    /// <param name="code">The code.</param>
    /// <param name="data">The data.</param>
    /// <param name="length">The length.</param>
    /// <returns></returns>
    public static Multihash Sum(HashType code, byte[] data, int length = -1) => _registry.Use(code, algo => Sum(algo, data, length));

    /// <summary>Sums the specified data.</summary>
    /// <typeparam name="TAlgorithm">The type of the algorithm.</typeparam>
    /// <param name="data">The data.</param>
    /// <param name="length">The length.</param>
    /// <returns></returns>
    public static Multihash Sum<TAlgorithm>(byte[] data, int length = -1) where TAlgorithm : IMultihashAlgorithm => _registry.Use<TAlgorithm, Multihash>(algo => Sum(algo, data, length));

    /// <summary>Sums the asynchronous.</summary>
    /// <param name="type">The type.</param>
    /// <param name="data">The data.</param>
    /// <param name="length">The length.</param>
    /// <returns></returns>
    public static Task<Multihash> SumAsync(HashType type, byte[] data, int length = -1) => _registry.UseAsync(type, algo => SumAsync(algo, data, length));

    /// <summary>Sums the asynchronous.</summary>
    /// <typeparam name="TAlgorithm">The type of the algorithm.</typeparam>
    /// <param name="data">The data.</param>
    /// <param name="length">The length.</param>
    /// <returns></returns>
    public static Task<Multihash> SumAsync<TAlgorithm>(byte[] data, int length = -1) where TAlgorithm : IMultihashAlgorithm => _registry.UseAsync<TAlgorithm, Multihash>(algo => SumAsync(algo, data, length));

    /// <summary>Tries the parse.</summary>
    /// <param name="s">The s.</param>
    /// <param name="mh">The mh.</param>
    /// <param name="encoding">The encoding.</param>
    /// <returns></returns>
    public static bool TryParse(string s, out Multihash mh, out MultibaseEncoding encoding)
    {
        foreach (var _encoding in _encodings)
        {
            try
            {
                encoding = _encoding;
                if (TryParse(s, encoding, out mh))
                {
                    return true;
                }
            }
            catch (Exception) { }
        }

        mh = null;
        encoding = (MultibaseEncoding)(-1);
        return false;
    }

    /// <summary>Tries the parse.</summary>
    /// <param name="s">The s.</param>
    /// <param name="mh">The mh.</param>
    /// <returns></returns>
    public static bool TryParse(string s, out Multihash mh)
    {
        return TryParse(s, out mh, out _);
    }

    /// <summary>Tries the parse.</summary>
    /// <param name="s">The s.</param>
    /// <param name="encoding">The encoding.</param>
    /// <param name="mh">The mh.</param>
    /// <returns></returns>
    public static bool TryParse(string s, MultibaseEncoding encoding, out Multihash mh)
    {
        try
        {
            var bytes = Multibase.DecodeRaw(encoding, s);
            mh = Decode(bytes);
            return true;
        }
        catch (Exception) { }

        mh = null;
        return false;
    }

    /// <summary>B58s the string.</summary>
    /// <returns></returns>
    [Obsolete("Use ToString() instead")]
    public string B58String() => ToString(MultibaseEncoding.Base58Btc);

    /// <summary>
    /// Determines whether the specified <see cref="object" />, is equal to this instance.
    /// </summary>
    /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
    /// <returns>
    ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
    /// </returns>
    public override bool Equals(object obj)
    {
        var other = (Multihash)obj;
        return other is not null && _bytes.Value.SequenceEqual(other._bytes.Value);
    }

    /// <inheritdoc />
    public override int GetHashCode() => (int)Code ^ Length ^ Digest.Sum(b => b);

    /// <summary>Converts to bytes.</summary>
    /// <returns></returns>
    public byte[] ToBytes() => _bytes.Value;

    /// <summary>Converts to hexstring.</summary>
    /// <returns></returns>
    [Obsolete("Use ToString() instead")]
    public string ToHexString() => ToString(MultibaseEncoding.Base16Lower);

    /// <summary>
    /// Converts to string.
    /// </summary>
    /// <param name="encoding">The encoding.</param>
    /// <returns>
    /// A <see cref="string" /> that represents this instance.
    /// </returns>
    public string ToString(MultibaseEncoding encoding) => Multibase.EncodeRaw(encoding, _bytes.Value);

    /// <inheritdoc />
    public override string ToString() => ToString(MultibaseEncoding.Base16Lower);

    /// <summary>Verifies the specified data.</summary>
    /// <param name="data">The data.</param>
    /// <returns></returns>
    public bool Verify(byte[] data) => Sum(Code, data, Length).Equals(this);

    /// <summary>Verifies the asynchronous.</summary>
    /// <param name="data">The data.</param>
    /// <returns></returns>
    public Task<bool> VerifyAsync(byte[] data) => SumAsync(Code, data, Length).ContinueWith(mh => mh.Result?.Equals(this) ?? false);

    private static Multihash Sum(IMultihashAlgorithm algo, byte[] data, int length) => new(algo.Code, algo.ComputeHash(data, length).Slice(0, length != -1 ? length : algo.DefaultLength));

    private static Task<Multihash> SumAsync(IMultihashAlgorithm algo, byte[] data, int length) => algo.ComputeHashAsync(data, length).ContinueWith(t => new Multihash(algo.Code, t.Result.Slice(0, length != -1 ? length : algo.DefaultLength)));
}
