namespace Multiformats.Hash;

using BinaryEncoding;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// The extensions class
/// </summary>
public static class Extensions
{
    /// <summary>Reads the multihash.</summary>
    /// <param name="stream">The stream.</param>
    /// <returns>The multihash.</returns>
    public static Multihash ReadMultihash(this Stream stream)
    {
        if (Binary.Varint.Read(stream, out uint code) <= 0)
        {
            return null;
        }

        if (Binary.Varint.Read(stream, out uint length) <= 0)
        {
            return null;
        }

        var buffer = new byte[length];
        return stream.Read(buffer, 0, buffer.Length) != length
            ? null
            : Multihash.Cast(Binary.Varint.GetBytes(code).Concat(Binary.Varint.GetBytes(length), buffer));
    }

    /// <summary>Reads the multihash asynchronous.</summary>
    /// <param name="stream">The stream.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The multihash.</returns>
    public static async Task<Multihash> ReadMultihashAsync(this Stream stream, CancellationToken cancellationToken)
    {
        var code = await Binary.Varint.ReadUInt32Async(stream, cancellationToken);
        // @Todo: we should check how many bytes we have read,
        //        but the method we're using doesn't support that.

        var length = await Binary.Varint.ReadUInt32Async(stream, cancellationToken);
        if (length == 0)
        {
            return null;
        }

        var buffer = new byte[length];
        return await stream.ReadAsync(buffer, cancellationToken) != length
            ? null
            : Multihash.Cast(Binary.Varint.GetBytes(code).Concat(Binary.Varint.GetBytes(length), buffer));
    }

    /// <summary>Writes the specified multihash.</summary>
    /// <param name="stream">The stream.</param>
    /// <param name="mh">The multihash.</param>
    public static void Write(this Stream stream, Multihash mh)
    {
        var bytes = mh.ToBytes();
        stream.Write(bytes, 0, bytes.Length);
    }

    /// <summary>Writes the asynchronous.</summary>
    /// <param name="stream">The stream.</param>
    /// <param name="mh">The mh.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A <see cref="Task"/>.</returns>
    public static Task WriteAsync(this Stream stream, Multihash mh, CancellationToken cancellationToken)
    {
        var bytes = mh.ToBytes();
        return stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken);
    }

    /// <summary>Slices the specified offset.</summary>
    /// <param name="buffer">The buffer.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="count">The count.</param>
    /// <returns></returns>
    internal static byte[] Slice(this byte[] buffer, int offset = 0, int? count = null)
    {
        var result = new byte[Math.Min(count ?? buffer.Length - offset, buffer.Length - offset)];
        Buffer.BlockCopy(buffer, offset, result, 0, result.Length);
        return result;
    }

    /// <summary>Concats the specified buffers.</summary>
    /// <param name="buffer">The buffer.</param>
    /// <param name="buffers">The buffers.</param>
    /// <returns></returns>
    internal static byte[] Concat(this byte[] buffer, params byte[][] buffers)
    {
        var result = new byte[buffer.Length + buffers.Sum(b => b.Length)];
        Buffer.BlockCopy(buffer, 0, result, 0, buffer.Length);
        var offset = buffer.Length;
        foreach (var buf in buffers)
        {
            Buffer.BlockCopy(buf, 0, result, offset, buf.Length);
            offset += buf.Length;
        }

        return result;
    }
}
