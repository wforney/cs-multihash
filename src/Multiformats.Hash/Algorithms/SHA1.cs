namespace Multiformats.Hash.Algorithms;

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Composition;

/// <summary>
/// The SHA1 class
/// </summary>
/// <seealso cref="Multiformats.Hash.Algorithms.MultihashAlgorithm" />
[Export(typeof(IMultihashAlgorithm))]
[MultihashAlgorithmExport(HashType.SHA1, "sha1", 20)]
public class SHA1 : MultihashAlgorithm
{
    private readonly Func<IDigest> _factory;

    /// <summary>Initializes a new instance of the <see cref="SHA1"/> class.</summary>
    public SHA1()
        : base(HashType.SHA1, "sha1", 20)
    {
        _factory = () => new Sha1Digest();
    }

    /// <summary>Computes the hash.</summary>
    /// <param name="data">The data.</param>
    /// <param name="length">The length.</param>
    /// <returns></returns>
    public override byte[] ComputeHash(byte[] data, int length = -1) => _factory().ComputeHash(data);
}
