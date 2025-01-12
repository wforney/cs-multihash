﻿namespace Multiformats.Hash.Algorithms;
using System;
using System.Composition;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;

public abstract class KECCAK : MultihashAlgorithm
{
    private readonly Func<IDigest> _factory;

    protected KECCAK(HashType code, string name, int defaultLength, Func<IDigest> factory)
        : base(code, name, defaultLength)
    {
        _factory = factory;
    }

    public override byte[] ComputeHash(byte[] data, int length = -1) => _factory().ComputeHash(data);
}

[Export(typeof(IMultihashAlgorithm))]
[MultihashAlgorithmExport(HashType.KECCAK_224, "keccak-224", 28)]
public class KECCAK_224 : KECCAK
{
    public KECCAK_224()
			: base(HashType.KECCAK_224, "keccak-224", 28, () => new KeccakDigest(224))
    {
    }
}

[Export(typeof(IMultihashAlgorithm))]
[MultihashAlgorithmExport(HashType.KECCAK_256, "keccak-256", 32)]
public class KECCAK_256 : KECCAK
{
    public KECCAK_256()
			: base(HashType.KECCAK_256, "keccak-256", 32, () => new KeccakDigest(256))
    {
    }
}

[Export(typeof(IMultihashAlgorithm))]
[MultihashAlgorithmExport(HashType.KECCAK_384, "keccak-384", 48)]
public class KECCAK_384 : KECCAK
{
    public KECCAK_384()
			: base(HashType.KECCAK_384, "keccak-384", 48, () => new KeccakDigest(384))
    {
    }
}

[Export(typeof(IMultihashAlgorithm))]
[MultihashAlgorithmExport(HashType.KECCAK_512, "keccak-512", 64)]
public class KECCAK_512 : KECCAK
{
    public KECCAK_512()
			: base(HashType.KECCAK_512, "keccak-512", 64, () => new KeccakDigest(512))
    {
    }
}
