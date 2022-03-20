namespace Multiformats.Hash;

/// <summary>
/// The hash type enumeration
/// </summary>
public enum HashType : uint
{
	/// <summary>
	/// ID
	/// </summary>
	ID = 0x00,

	/// <summary>
	/// MD4
	/// </summary>
	MD4 = 0xd4,

	/// <summary>
	/// MD5
	/// </summary>
	MD5 = 0xd5,

	/// <summary>
	/// SHA1
	/// </summary>
	SHA1 = 0x11,

	/// <summary>
	/// SHA2 256
	/// </summary>
	SHA2_256 = 0x12,

	/// <summary>
	/// SHA2 512
	/// </summary>
	SHA2_512 = 0x13,

	/// <summary>
	/// SHA3 512
	/// </summary>
	SHA3_512 = 0x14,

	/// <summary>
	/// SHA3 384
	/// </summary>
	SHA3_384 = 0x15,

	/// <summary>
	/// SHA3 256
	/// </summary>
	SHA3_256 = 0x16,

	/// <summary>
	/// SHA3 224
	/// </summary>
	SHA3_224 = 0x17,

	/// <summary>
	/// Shake 128
	/// </summary>
	SHAKE_128 = 0x18,

	/// <summary>
	/// Shake 256
	/// </summary>
	SHAKE_256 = 0x19,

	/// <summary>
	/// Keccak 224 bits
	/// </summary>
	KECCAK_224 = 0x1A,

	/// <summary>
	/// Keccak 256 bits
	/// </summary>
	KECCAK_256 = 0x1B,

	/// <summary>
	/// Keccak 384 bits
	/// </summary>
	KECCAK_384 = 0x1C,

	/// <summary>
	/// Keccak 512 bits
	/// </summary>
	KECCAK_512 = 0x1D,

	/// <summary>
	/// MurMur3 128
	/// </summary>
	MURMUR3_128 = 0x23,

	/// <summary>
	/// MurMur3 32
	/// </summary>
	MURMUR3_32 = 0x22,

	/// <summary>
	/// Blake 2b 8
	/// </summary>
	BLAKE2B_8 = 0xb201,

	/// <summary>
	/// Blake 2b 16
	/// </summary>
	BLAKE2B_16 = 0xb202,

	/// <summary>
	/// Blake 2b 24
	/// </summary>
	BLAKE2B_24 = 0xb203,

	/// <summary>
	/// Blake 2b 32
	/// </summary>
	BLAKE2B_32 = 0xb204,

	/// <summary>
	/// Blake 2b 40
	/// </summary>
	BLAKE2B_40 = 0xb205,

	/// <summary>
	/// Blake 2b 48
	/// </summary>
	BLAKE2B_48 = 0xb206,

	/// <summary>
	/// Blake 2b 56
	/// </summary>
	BLAKE2B_56 = 0xb207,

	/// <summary>
	/// Blake 2b 64
	/// </summary>
	BLAKE2B_64 = 0xb208,

	/// <summary>
	/// Blake 2b 72
	/// </summary>
	BLAKE2B_72 = 0xb209,

	/// <summary>
	/// Blake 2b 80
	/// </summary>
	BLAKE2B_80 = 0xb20a,

	/// <summary>
	/// Blake 2b 88
	/// </summary>
	BLAKE2B_88 = 0xb20b,

	/// <summary>
	/// Blake 2b 96
	/// </summary>
	BLAKE2B_96 = 0xb20c,

	/// <summary>
	/// Blake 2b 104
	/// </summary>
	BLAKE2B_104 = 0xb20d,

	/// <summary>
	/// Blake 2b 112
	/// </summary>
	BLAKE2B_112 = 0xb20e,

	/// <summary>
	/// Blake 2b 120
	/// </summary>
	BLAKE2B_120 = 0xb20f,

	/// <summary>
	/// Blake 2b 128
	/// </summary>
	BLAKE2B_128 = 0xb210,

	/// <summary>
	/// Blake 2b 136
	/// </summary>
	BLAKE2B_136 = 0xb211,

	/// <summary>
	/// Blake 2b 144
	/// </summary>
	BLAKE2B_144 = 0xb212,

	/// <summary>
	/// Blake 2b 152
	/// </summary>
	BLAKE2B_152 = 0xb213,

	/// <summary>
	/// Blake 2b 160
	/// </summary>
	BLAKE2B_160 = 0xb214,

	/// <summary>
	/// Blake 2b 168
	/// </summary>
	BLAKE2B_168 = 0xb215,

	/// <summary>
	/// Blake 2b 176
	/// </summary>
	BLAKE2B_176 = 0xb216,

	/// <summary>
	/// Blake 2b 184
	/// </summary>
	BLAKE2B_184 = 0xb217,

	/// <summary>
	/// Blake 2b 192
	/// </summary>
	BLAKE2B_192 = 0xb218,

	/// <summary>
	/// Blake 2b 200
	/// </summary>
	BLAKE2B_200 = 0xb219,

	/// <summary>
	/// Blake 2b 208
	/// </summary>
	BLAKE2B_208 = 0xb21a,

	/// <summary>
	/// Blake 2b 216
	/// </summary>
	BLAKE2B_216 = 0xb21b,

	/// <summary>
	/// Blake 2b 224
	/// </summary>
	BLAKE2B_224 = 0xb21c,

	/// <summary>
	/// Blake 2b 232
	/// </summary>
	BLAKE2B_232 = 0xb21d,

	/// <summary>
	/// Blake 2b 240
	/// </summary>
	BLAKE2B_240 = 0xb21e,

	/// <summary>
	/// Blake 2b 248
	/// </summary>
	BLAKE2B_248 = 0xb21f,

	/// <summary>
	/// Blake 2b 256
	/// </summary>
	BLAKE2B_256 = 0xb220,

	/// <summary>
	/// Blake 2b 264
	/// </summary>
	BLAKE2B_264 = 0xb221,

	/// <summary>
	/// Blake 2b 272
	/// </summary>
	BLAKE2B_272 = 0xb222,

	/// <summary>
	/// Blake 2b 280
	/// </summary>
	BLAKE2B_280 = 0xb223,

	/// <summary>
	/// Blake 2b 288
	/// </summary>
	BLAKE2B_288 = 0xb224,

	/// <summary>
	/// Blake 2b 296
	/// </summary>
	BLAKE2B_296 = 0xb225,

	/// <summary>
	/// Blake 2b 304
	/// </summary>
	BLAKE2B_304 = 0xb226,

	/// <summary>
	/// Blake 2b 312
	/// </summary>
	BLAKE2B_312 = 0xb227,

	/// <summary>
	/// Blake 2b 320
	/// </summary>
	BLAKE2B_320 = 0xb228,

	/// <summary>
	/// Blake 2b 328
	/// </summary>
	BLAKE2B_328 = 0xb229,

	/// <summary>
	/// Blake 2b 336
	/// </summary>
	BLAKE2B_336 = 0xb22a,

	/// <summary>
	/// Blake 2b 344
	/// </summary>
	BLAKE2B_344 = 0xb22b,

	/// <summary>
	/// Blake 2b 352
	/// </summary>
	BLAKE2B_352 = 0xb22c,

	/// <summary>
	/// Blake 2b 360
	/// </summary>
	BLAKE2B_360 = 0xb22d,

	/// <summary>
	/// Blake 2b 368
	/// </summary>
	BLAKE2B_368 = 0xb22e,

	/// <summary>
	/// Blake 2b 376
	/// </summary>
	BLAKE2B_376 = 0xb22f,

	/// <summary>
	/// Blake 2b 384
	/// </summary>
	BLAKE2B_384 = 0xb230,

	/// <summary>
	/// Blake 2b 392
	/// </summary>
	BLAKE2B_392 = 0xb231,

	/// <summary>
	/// Blake 2b 400
	/// </summary>
	BLAKE2B_400 = 0xb232,

	/// <summary>
	/// Blake 2b 408
	/// </summary>
	BLAKE2B_408 = 0xb233,

	/// <summary>
	/// Blake 2b 416
	/// </summary>
	BLAKE2B_416 = 0xb234,

	/// <summary>
	/// Blake 2b 424
	/// </summary>
	BLAKE2B_424 = 0xb235,

	/// <summary>
	/// Blake 2b 432
	/// </summary>
	BLAKE2B_432 = 0xb236,

	/// <summary>
	/// Blake 2b 440
	/// </summary>
	BLAKE2B_440 = 0xb237,

	/// <summary>
	/// Blake 2b 448
	/// </summary>
	BLAKE2B_448 = 0xb238,

	/// <summary>
	/// Blake 2b 456
	/// </summary>
	BLAKE2B_456 = 0xb239,

	/// <summary>
	/// Blake 2b 464
	/// </summary>
	BLAKE2B_464 = 0xb23a,

	/// <summary>
	/// Blake 2b 472
	/// </summary>
	BLAKE2B_472 = 0xb23b,

	/// <summary>
	/// Blake 2b 480
	/// </summary>
	BLAKE2B_480 = 0xb23c,

	/// <summary>
	/// Blake 2b 488
	/// </summary>
	BLAKE2B_488 = 0xb23d,

	/// <summary>
	/// Blake 2b 496
	/// </summary>
	BLAKE2B_496 = 0xb23e,

	/// <summary>
	/// Blake 2b 504
	/// </summary>
	BLAKE2B_504 = 0xb23f,

	/// <summary>
	/// Blake 2b 512
	/// </summary>
	BLAKE2B_512 = 0xb240,

	/// <summary>
	/// Blake 2s 8
	/// </summary>
	BLAKE2S_8 = 0xb241,

	/// <summary>
	/// Blake 2s 16
	/// </summary>
	BLAKE2S_16 = 0xb242,

	/// <summary>
	/// Blake 2s 24
	/// </summary>
	BLAKE2S_24 = 0xb243,

	/// <summary>
	/// Blake 2s 32
	/// </summary>
	BLAKE2S_32 = 0xb244,

	/// <summary>
	/// Blake 2s 40
	/// </summary>
	BLAKE2S_40 = 0xb245,

	/// <summary>
	/// Blake 2s 48
	/// </summary>
	BLAKE2S_48 = 0xb246,

	/// <summary>
	/// Blake 2s 56
	/// </summary>
	BLAKE2S_56 = 0xb247,

	/// <summary>
	/// Blake 2s 64
	/// </summary>
	BLAKE2S_64 = 0xb248,

	/// <summary>
	/// Blake 2s 72
	/// </summary>
	BLAKE2S_72 = 0xb249,

	/// <summary>
	/// Blake 2s 80
	/// </summary>
	BLAKE2S_80 = 0xb24a,

	/// <summary>
	/// Blake 2s 88
	/// </summary>
	BLAKE2S_88 = 0xb24b,

	/// <summary>
	/// Blake 2s 96
	/// </summary>
	BLAKE2S_96 = 0xb24c,

	/// <summary>
	/// Blake 2s 104
	/// </summary>
	BLAKE2S_104 = 0xb24d,

	/// <summary>
	/// Blake 2s 112
	/// </summary>
	BLAKE2S_112 = 0xb24e,

	/// <summary>
	/// Blake 2s 120
	/// </summary>
	BLAKE2S_120 = 0xb24f,

	/// <summary>
	/// Blake 2s 128
	/// </summary>
	BLAKE2S_128 = 0xb250,

	/// <summary>
	/// Blake 2s 136
	/// </summary>
	BLAKE2S_136 = 0xb251,

	/// <summary>
	/// Blake 2s 144
	/// </summary>
	BLAKE2S_144 = 0xb252,

	/// <summary>
	/// Blake 2s 152
	/// </summary>
	BLAKE2S_152 = 0xb253,

	/// <summary>
	/// Blake 2s 160
	/// </summary>
	BLAKE2S_160 = 0xb254,

	/// <summary>
	/// Blake 2s 168
	/// </summary>
	BLAKE2S_168 = 0xb255,

	/// <summary>
	/// Blake 2s 176
	/// </summary>
	BLAKE2S_176 = 0xb256,

	/// <summary>
	/// Blake 2s 184
	/// </summary>
	BLAKE2S_184 = 0xb257,

	/// <summary>
	/// Blake 2s 192
	/// </summary>
	BLAKE2S_192 = 0xb258,

	/// <summary>
	/// Blake 2s 200
	/// </summary>
	BLAKE2S_200 = 0xb259,

	/// <summary>
	/// Blake 2s 208
	/// </summary>
	BLAKE2S_208 = 0xb25a,

	/// <summary>
	/// Blake 2s 216
	/// </summary>
	BLAKE2S_216 = 0xb25b,

	/// <summary>
	/// Blake 2s 224
	/// </summary>
	BLAKE2S_224 = 0xb25c,

	/// <summary>
	/// Blake 2s 232
	/// </summary>
	BLAKE2S_232 = 0xb25d,

	/// <summary>
	/// Blake 2s 240
	/// </summary>
	BLAKE2S_240 = 0xb25e,

	/// <summary>
	/// Blake 2s 248
	/// </summary>
	BLAKE2S_248 = 0xb25f,

	/// <summary>
	/// Blake 2s 256
	/// </summary>
	BLAKE2S_256 = 0xb260,

	/// <summary>
	/// Skein 256 bits 8 length
	/// </summary>
	SKEIN256_8 = 0xb301,

	/// <summary>
	/// Skein 256 bits 16 length
	/// </summary>
	SKEIN256_16 = 0xb302,

	/// <summary>
	/// Skein 256 bits 24 length
	/// </summary>
	SKEIN256_24 = 0xb303,

	/// <summary>
	/// Skein 256 bits 32 length
	/// </summary>
	SKEIN256_32 = 0xb304,

	/// <summary>
	/// Skein 256 bits 40 length
	/// </summary>
	SKEIN256_40 = 0xb305,

	/// <summary>
	/// Skein 256 bits 48 length
	/// </summary>
	SKEIN256_48 = 0xb306,

	/// <summary>
	/// Skein 256 bits 56 length
	/// </summary>
	SKEIN256_56 = 0xb307,

	/// <summary>
	/// Skein 256 bits 64 length
	/// </summary>
	SKEIN256_64 = 0xb308,

	/// <summary>
	/// Skein 256 bits 72 length
	/// </summary>
	SKEIN256_72 = 0xb309,

	/// <summary>
	/// Skein 256 bits 80 length
	/// </summary>
	SKEIN256_80 = 0xb30a,

	/// <summary>
	/// Skein 256 bits 88 length
	/// </summary>
	SKEIN256_88 = 0xb30b,

	/// <summary>
	/// Skein 256 bits 96 length
	/// </summary>
	SKEIN256_96 = 0xb30c,

	/// <summary>
	/// Skein 256 bits 104 length
	/// </summary>
	SKEIN256_104 = 0xb30d,

	/// <summary>
	/// Skein 256 bits 112 length
	/// </summary>
	SKEIN256_112 = 0xb30e,

	/// <summary>
	/// Skein 256 bits 120 length
	/// </summary>
	SKEIN256_120 = 0xb30f,

	/// <summary>
	/// Skein 256 bits 128 length
	/// </summary>
	SKEIN256_128 = 0xb310,

	/// <summary>
	/// Skein 256 bits 136 length
	/// </summary>
	SKEIN256_136 = 0xb311,

	/// <summary>
	/// Skein 256 bits 144 length
	/// </summary>
	SKEIN256_144 = 0xb312,

	/// <summary>
	/// Skein 256 bits 152 length
	/// </summary>
	SKEIN256_152 = 0xb313,

	/// <summary>
	/// Skein 256 bits 160 length
	/// </summary>
	SKEIN256_160 = 0xb314,

	/// <summary>
	/// Skein 256 bits 168 length
	/// </summary>
	SKEIN256_168 = 0xb315,

	/// <summary>
	/// Skein 256 bits 176 length
	/// </summary>
	SKEIN256_176 = 0xb316,

	/// <summary>
	/// Skein 256 bits 184 length
	/// </summary>
	SKEIN256_184 = 0xb317,

	/// <summary>
	/// Skein 256 bits 192 length
	/// </summary>
	SKEIN256_192 = 0xb318,

	/// <summary>
	/// Skein 256 bits 200 length
	/// </summary>
	SKEIN256_200 = 0xb319,

	/// <summary>
	/// Skein 256 bits 208 length
	/// </summary>
	SKEIN256_208 = 0xb31a,

	/// <summary>
	/// Skein 256 bits 216 length
	/// </summary>
	SKEIN256_216 = 0xb31b,

	/// <summary>
	/// Skein 256 bits 224 length
	/// </summary>
	SKEIN256_224 = 0xb31c,

	/// <summary>
	/// Skein 256 bits 232 length
	/// </summary>
	SKEIN256_232 = 0xb31d,

	/// <summary>
	/// Skein 256 bits 240 length
	/// </summary>
	SKEIN256_240 = 0xb31e,

	/// <summary>
	/// Skein 256 bits 248 length
	/// </summary>
	SKEIN256_248 = 0xb31f,

	/// <summary>
	/// Skein 256 bits 256 length
	/// </summary>
	SKEIN256_256 = 0xb320,

	/// <summary>
	/// Skein 512 bits 8 length
	/// </summary>
	SKEIN512_8 = 0xb321,

	/// <summary>
	/// Skein 512 bits 16 length
	/// </summary>
	SKEIN512_16 = 0xb322,

	/// <summary>
	/// Skein 512 bits 24 length
	/// </summary>
	SKEIN512_24 = 0xb323,

	/// <summary>
	/// Skein 512 bits 32 length
	/// </summary>
	SKEIN512_32 = 0xb324,

	/// <summary>
	/// Skein 512 bits 40 length
	/// </summary>
	SKEIN512_40 = 0xb325,

	/// <summary>
	/// Skein 512 bits 48 length
	/// </summary>
	SKEIN512_48 = 0xb326,

	/// <summary>
	/// Skein 512 bits 56 length
	/// </summary>
	SKEIN512_56 = 0xb327,

	/// <summary>
	/// Skein 512 bits 64 length
	/// </summary>
	SKEIN512_64 = 0xb328,

	/// <summary>
	/// Skein 512 bits 72 length
	/// </summary>
	SKEIN512_72 = 0xb329,

	/// <summary>
	/// Skein 512 bits 80 length
	/// </summary>
	SKEIN512_80 = 0xb32a,

	/// <summary>
	/// Skein 512 bits 88 length
	/// </summary>
	SKEIN512_88 = 0xb32b,

	/// <summary>
	/// Skein 512 bits 96 length
	/// </summary>
	SKEIN512_96 = 0xb32c,

	/// <summary>
	/// Skein 512 bits 104 length
	/// </summary>
	SKEIN512_104 = 0xb32d,

	/// <summary>
	/// Skein 512 bits 112 length
	/// </summary>
	SKEIN512_112 = 0xb32e,

	/// <summary>
	/// Skein 512 bits 120 length
	/// </summary>
	SKEIN512_120 = 0xb32f,

	/// <summary>
	/// Skein 512 bits 128 length
	/// </summary>
	SKEIN512_128 = 0xb330,

	/// <summary>
	/// Skein 512 bits 136 length
	/// </summary>
	SKEIN512_136 = 0xb331,

	/// <summary>
	/// Skein 512 bits 144 length
	/// </summary>
	SKEIN512_144 = 0xb332,

	/// <summary>
	/// Skein 512 bits 152 length
	/// </summary>
	SKEIN512_152 = 0xb333,

	/// <summary>
	/// Skein 512 bits 160 length
	/// </summary>
	SKEIN512_160 = 0xb334,

	/// <summary>
	/// Skein 512 bits 168 length
	/// </summary>
	SKEIN512_168 = 0xb335,

	/// <summary>
	/// Skein 512 bits 176 length
	/// </summary>
	SKEIN512_176 = 0xb336,

	/// <summary>
	/// Skein 512 bits 184 length
	/// </summary>
	SKEIN512_184 = 0xb337,

	/// <summary>
	/// Skein 512 bits 192 length
	/// </summary>
	SKEIN512_192 = 0xb338,

	/// <summary>
	/// Skein 512 bits 200 length
	/// </summary>
	SKEIN512_200 = 0xb339,

	/// <summary>
	/// Skein 512 bits 208 length
	/// </summary>
	SKEIN512_208 = 0xb33a,

	/// <summary>
	/// Skein 512 bits 216 length
	/// </summary>
	SKEIN512_216 = 0xb33b,

	/// <summary>
	/// Skein 512 bits 224 length
	/// </summary>
	SKEIN512_224 = 0xb33c,

	/// <summary>
	/// Skein 512 bits 232 length
	/// </summary>
	SKEIN512_232 = 0xb33d,

	/// <summary>
	/// Skein 512 bits 240 length
	/// </summary>
	SKEIN512_240 = 0xb33e,

	/// <summary>
	/// Skein 512 bits 248 length
	/// </summary>
	SKEIN512_248 = 0xb33f,

	/// <summary>
	/// Skein 512 bits 256 length
	/// </summary>
	SKEIN512_256 = 0xb340,

	/// <summary>
	/// Skein 512 bits 264 length
	/// </summary>
	SKEIN512_264 = 0xb341,

	/// <summary>
	/// Skein 512 bits 272 length
	/// </summary>
	SKEIN512_272 = 0xb342,

	/// <summary>
	/// Skein 512 bits 280 length
	/// </summary>
	SKEIN512_280 = 0xb343,

	/// <summary>
	/// Skein 512 bits 288 length
	/// </summary>
	SKEIN512_288 = 0xb344,

	/// <summary>
	/// Skein 512 bits 296 length
	/// </summary>
	SKEIN512_296 = 0xb345,

	/// <summary>
	/// Skein 512 bits 304 length
	/// </summary>
	SKEIN512_304 = 0xb346,

	/// <summary>
	/// Skein 512 bits 312 length
	/// </summary>
	SKEIN512_312 = 0xb347,

	/// <summary>
	/// Skein 512 bits 320 length
	/// </summary>
	SKEIN512_320 = 0xb348,

	/// <summary>
	/// Skein 512 bits 328 length
	/// </summary>
	SKEIN512_328 = 0xb349,

	/// <summary>
	/// Skein 512 bits 336 length
	/// </summary>
	SKEIN512_336 = 0xb34a,

	/// <summary>
	/// Skein 512 bits 344 length
	/// </summary>
	SKEIN512_344 = 0xb34b,

	/// <summary>
	/// Skein 512 bits 352 length
	/// </summary>
	SKEIN512_352 = 0xb34c,

	/// <summary>
	/// Skein 512 bits 360 length
	/// </summary>
	SKEIN512_360 = 0xb34d,

	/// <summary>
	/// Skein 512 bits 368 length
	/// </summary>
	SKEIN512_368 = 0xb34e,

	/// <summary>
	/// Skein 512 bits 376 length
	/// </summary>
	SKEIN512_376 = 0xb34f,

	/// <summary>
	/// Skein 512 bits 384 length
	/// </summary>
	SKEIN512_384 = 0xb350,

	/// <summary>
	/// Skein 512 bits 392 length
	/// </summary>
	SKEIN512_392 = 0xb351,

	/// <summary>
	/// Skein 512 bits 400 length
	/// </summary>
	SKEIN512_400 = 0xb352,

	/// <summary>
	/// Skein 512 bits 408 length
	/// </summary>
	SKEIN512_408 = 0xb353,

	/// <summary>
	/// Skein 512 bits 416 length
	/// </summary>
	SKEIN512_416 = 0xb354,

	/// <summary>
	/// Skein 512 bits 424 length
	/// </summary>
	SKEIN512_424 = 0xb355,

	/// <summary>
	/// Skein 512 bits 432 length
	/// </summary>
	SKEIN512_432 = 0xb356,

	/// <summary>
	/// Skein 512 bits 440 length
	/// </summary>
	SKEIN512_440 = 0xb357,

	/// <summary>
	/// Skein 512 bits 448 length
	/// </summary>
	SKEIN512_448 = 0xb358,

	/// <summary>
	/// Skein 512 bits 456 length
	/// </summary>
	SKEIN512_456 = 0xb359,

	/// <summary>
	/// Skein 512 bits 464 length
	/// </summary>
	SKEIN512_464 = 0xb35a,

	/// <summary>
	/// Skein 512 bits 472 length
	/// </summary>
	SKEIN512_472 = 0xb35b,

	/// <summary>
	/// Skein 512 bits 480 length
	/// </summary>
	SKEIN512_480 = 0xb35c,

	/// <summary>
	/// Skein 512 bits 488 length
	/// </summary>
	SKEIN512_488 = 0xb35d,

	/// <summary>
	/// Skein 512 bits 496 length
	/// </summary>
	SKEIN512_496 = 0xb35e,

	/// <summary>
	/// Skein 512 bits 504 length
	/// </summary>
	SKEIN512_504 = 0xb35f,

	/// <summary>
	/// Skein 512 bits 512 length
	/// </summary>
	SKEIN512_512 = 0xb360,

	/// <summary>
	/// Skein 1024 bits 8 length
	/// </summary>
	SKEIN1024_8 = 0xb361,

	/// <summary>
	/// Skein 1024 bits 16 length
	/// </summary>
	SKEIN1024_16 = 0xb362,

	/// <summary>
	/// Skein 1024 bits 24 length
	/// </summary>
	SKEIN1024_24 = 0xb363,

	/// <summary>
	/// Skein 1024 bits 32 length
	/// </summary>
	SKEIN1024_32 = 0xb364,

	/// <summary>
	/// Skein 1024 bits 40 length
	/// </summary>
	SKEIN1024_40 = 0xb365,

	/// <summary>
	/// Skein 1024 bits 48 length
	/// </summary>
	SKEIN1024_48 = 0xb366,

	/// <summary>
	/// Skein 1024 bits 56 length
	/// </summary>
	SKEIN1024_56 = 0xb367,

	/// <summary>
	/// Skein 1024 bits 64 length
	/// </summary>
	SKEIN1024_64 = 0xb368,

	/// <summary>
	/// Skein 1024 bits 72 length
	/// </summary>
	SKEIN1024_72 = 0xb369,

	/// <summary>
	/// Skein 1024 bits 80 length
	/// </summary>
	SKEIN1024_80 = 0xb36a,

	/// <summary>
	/// Skein 1024 bits 88 length
	/// </summary>
	SKEIN1024_88 = 0xb36b,

	/// <summary>
	/// Skein 1024 bits 96 length
	/// </summary>
	SKEIN1024_96 = 0xb36c,

	/// <summary>
	/// Skein 1024 bits 104 length
	/// </summary>
	SKEIN1024_104 = 0xb36d,

	/// <summary>
	/// Skein 1024 bits 112 length
	/// </summary>
	SKEIN1024_112 = 0xb36e,

	/// <summary>
	/// Skein 1024 bits 120 length
	/// </summary>
	SKEIN1024_120 = 0xb36f,

	/// <summary>
	/// Skein 1024 bits 128 length
	/// </summary>
	SKEIN1024_128 = 0xb370,

	/// <summary>
	/// Skein 1024 bits 136 length
	/// </summary>
	SKEIN1024_136 = 0xb371,

	/// <summary>
	/// Skein 1024 bits 144 length
	/// </summary>
	SKEIN1024_144 = 0xb372,

	/// <summary>
	/// Skein 1024 bits 152 length
	/// </summary>
	SKEIN1024_152 = 0xb373,

	/// <summary>
	/// Skein 1024 bits 160 length
	/// </summary>
	SKEIN1024_160 = 0xb374,

	/// <summary>
	/// Skein 1024 bits 168 length
	/// </summary>
	SKEIN1024_168 = 0xb375,

	/// <summary>
	/// Skein 1024 bits 176 length
	/// </summary>
	SKEIN1024_176 = 0xb376,

	/// <summary>
	/// Skein 1024 bits 184 length
	/// </summary>
	SKEIN1024_184 = 0xb377,

	/// <summary>
	/// Skein 1024 bits 192 length
	/// </summary>
	SKEIN1024_192 = 0xb378,

	/// <summary>
	/// Skein 1024 bits 200 length
	/// </summary>
	SKEIN1024_200 = 0xb379,

	/// <summary>
	/// Skein 1024 bits 208 length
	/// </summary>
	SKEIN1024_208 = 0xb37a,

	/// <summary>
	/// Skein 1024 bits 216 length
	/// </summary>
	SKEIN1024_216 = 0xb37b,

	/// <summary>
	/// Skein 1024 bits 224 length
	/// </summary>
	SKEIN1024_224 = 0xb37c,

	/// <summary>
	/// Skein 1024 bits 232 length
	/// </summary>
	SKEIN1024_232 = 0xb37d,

	/// <summary>
	/// Skein 1024 bits 240 length
	/// </summary>
	SKEIN1024_240 = 0xb37e,

	/// <summary>
	/// Skein 1024 bits 248 length
	/// </summary>
	SKEIN1024_248 = 0xb37f,

	/// <summary>
	/// Skein 1024 bits 256 length
	/// </summary>
	SKEIN1024_256 = 0xb380,

	/// <summary>
	/// Skein 1024 bits 264 length
	/// </summary>
	SKEIN1024_264 = 0xb381,

	/// <summary>
	/// Skein 1024 bits 272 length
	/// </summary>
	SKEIN1024_272 = 0xb382,

	/// <summary>
	/// Skein 1024 bits 280 length
	/// </summary>
	SKEIN1024_280 = 0xb383,

	/// <summary>
	/// Skein 1024 bits 288 length
	/// </summary>
	SKEIN1024_288 = 0xb384,

	/// <summary>
	/// Skein 1024 bits 296 length
	/// </summary>
	SKEIN1024_296 = 0xb385,

	/// <summary>
	/// Skein 1024 bits 304 length
	/// </summary>
	SKEIN1024_304 = 0xb386,

	/// <summary>
	/// Skein 1024 bits 312 length
	/// </summary>
	SKEIN1024_312 = 0xb387,

	/// <summary>
	/// Skein 1024 bits 320 length
	/// </summary>
	SKEIN1024_320 = 0xb388,

	/// <summary>
	/// Skein 1024 bits 328 length
	/// </summary>
	SKEIN1024_328 = 0xb389,

	/// <summary>
	/// Skein 1024 bits 336 length
	/// </summary>
	SKEIN1024_336 = 0xb38a,

	/// <summary>
	/// Skein 1024 bits 344 length
	/// </summary>
	SKEIN1024_344 = 0xb38b,

	/// <summary>
	/// Skein 1024 bits 352 length
	/// </summary>
	SKEIN1024_352 = 0xb38c,

	/// <summary>
	/// Skein 1024 bits 360 length
	/// </summary>
	SKEIN1024_360 = 0xb38d,

	/// <summary>
	/// Skein 1024 bits 368 length
	/// </summary>
	SKEIN1024_368 = 0xb38e,

	/// <summary>
	/// Skein 1024 bits 376 length
	/// </summary>
	SKEIN1024_376 = 0xb38f,

	/// <summary>
	/// Skein 1024 bits 384 length
	/// </summary>
	SKEIN1024_384 = 0xb390,

	/// <summary>
	/// Skein 1024 bits 392 length
	/// </summary>
	SKEIN1024_392 = 0xb391,

	/// <summary>
	/// Skein 1024 bits 400 length
	/// </summary>
	SKEIN1024_400 = 0xb392,

	/// <summary>
	/// Skein 1024 bits 408 length
	/// </summary>
	SKEIN1024_408 = 0xb393,

	/// <summary>
	/// Skein 1024 bits 416 length
	/// </summary>
	SKEIN1024_416 = 0xb394,

	/// <summary>
	/// Skein 1024 bits 424 length
	/// </summary>
	SKEIN1024_424 = 0xb395,

	/// <summary>
	/// Skein 1024 bits 432 length
	/// </summary>
	SKEIN1024_432 = 0xb396,

	/// <summary>
	/// Skein 1024 bits 440 length
	/// </summary>
	SKEIN1024_440 = 0xb397,

	/// <summary>
	/// Skein 1024 bits 448 length
	/// </summary>
	SKEIN1024_448 = 0xb398,

	/// <summary>
	/// Skein 1024 bits 456 length
	/// </summary>
	SKEIN1024_456 = 0xb399,

	/// <summary>
	/// Skein 1024 bits 464 length
	/// </summary>
	SKEIN1024_464 = 0xb39a,

	/// <summary>
	/// Skein 1024 bits 472 length
	/// </summary>
	SKEIN1024_472 = 0xb39b,

	/// <summary>
	/// Skein 1024 bits 480 length
	/// </summary>
	SKEIN1024_480 = 0xb39c,

	/// <summary>
	/// Skein 1024 bits 488 length
	/// </summary>
	SKEIN1024_488 = 0xb39d,

	/// <summary>
	/// Skein 1024 bits 496 length
	/// </summary>
	SKEIN1024_496 = 0xb39e,

	/// <summary>
	/// Skein 1024 bits 504 length
	/// </summary>
	SKEIN1024_504 = 0xb39f,

	/// <summary>
	/// Skein 1024 bits 512 length
	/// </summary>
	SKEIN1024_512 = 0xb3a0,

	/// <summary>
	/// Skein 1024 bits 520 length
	/// </summary>
	SKEIN1024_520 = 0xb3a1,

	/// <summary>
	/// Skein 1024 bits 528 length
	/// </summary>
	SKEIN1024_528 = 0xb3a2,

	/// <summary>
	/// Skein 1024 bits 536 length
	/// </summary>
	SKEIN1024_536 = 0xb3a3,

	/// <summary>
	/// Skein 1024 bits 544 length
	/// </summary>
	SKEIN1024_544 = 0xb3a4,

	/// <summary>
	/// Skein 1024 bits 552 length
	/// </summary>
	SKEIN1024_552 = 0xb3a5,

	/// <summary>
	/// Skein 1024 bits 560 length
	/// </summary>
	SKEIN1024_560 = 0xb3a6,

	/// <summary>
	/// Skein 1024 bits 568 length
	/// </summary>
	SKEIN1024_568 = 0xb3a7,

	/// <summary>
	/// Skein 1024 bits 576 length
	/// </summary>
	SKEIN1024_576 = 0xb3a8,

	/// <summary>
	/// Skein 1024 bits 584 length
	/// </summary>
	SKEIN1024_584 = 0xb3a9,

	/// <summary>
	/// Skein 1024 bits 592 length
	/// </summary>
	SKEIN1024_592 = 0xb3aa,

	/// <summary>
	/// Skein 1024 bits 600 length
	/// </summary>
	SKEIN1024_600 = 0xb3ab,

	/// <summary>
	/// Skein 1024 bits 608 length
	/// </summary>
	SKEIN1024_608 = 0xb3ac,

	/// <summary>
	/// Skein 1024 bits 616 length
	/// </summary>
	SKEIN1024_616 = 0xb3ad,

	/// <summary>
	/// Skein 1024 bits 624 length
	/// </summary>
	SKEIN1024_624 = 0xb3ae,

	/// <summary>
	/// Skein 1024 bits 632 length
	/// </summary>
	SKEIN1024_632 = 0xb3af,

	/// <summary>
	/// Skein 1024 bits 640 length
	/// </summary>
	SKEIN1024_640 = 0xb3b0,

	/// <summary>
	/// Skein 1024 bits 648 length
	/// </summary>
	SKEIN1024_648 = 0xb3b1,

	/// <summary>
	/// Skein 1024 bits 656 length
	/// </summary>
	SKEIN1024_656 = 0xb3b2,

	/// <summary>
	/// Skein 1024 bits 664 length
	/// </summary>
	SKEIN1024_664 = 0xb3b3,

	/// <summary>
	/// Skein 1024 bits 672 length
	/// </summary>
	SKEIN1024_672 = 0xb3b4,

	/// <summary>
	/// Skein 1024 bits 680 length
	/// </summary>
	SKEIN1024_680 = 0xb3b5,

	/// <summary>
	/// Skein 1024 bits 688 length
	/// </summary>
	SKEIN1024_688 = 0xb3b6,

	/// <summary>
	/// Skein 1024 bits 696 length
	/// </summary>
	SKEIN1024_696 = 0xb3b7,

	/// <summary>
	/// Skein 1024 bits 704 length
	/// </summary>
	SKEIN1024_704 = 0xb3b8,

	/// <summary>
	/// Skein 1024 bits 712 length
	/// </summary>
	SKEIN1024_712 = 0xb3b9,

	/// <summary>
	/// Skein 1024 bits 720 length
	/// </summary>
	SKEIN1024_720 = 0xb3ba,

	/// <summary>
	/// Skein 1024 bits 728 length
	/// </summary>
	SKEIN1024_728 = 0xb3bb,

	/// <summary>
	/// Skein 1024 bits 736 length
	/// </summary>
	SKEIN1024_736 = 0xb3bc,

	/// <summary>
	/// Skein 1024 bits 744 length
	/// </summary>
	SKEIN1024_744 = 0xb3bd,

	/// <summary>
	/// Skein 1024 bits 752 length
	/// </summary>
	SKEIN1024_752 = 0xb3be,

	/// <summary>
	/// Skein 1024 bits 760 length
	/// </summary>
	SKEIN1024_760 = 0xb3bf,

	/// <summary>
	/// Skein 1024 bits 768 length
	/// </summary>
	SKEIN1024_768 = 0xb3c0,

	/// <summary>
	/// Skein 1024 bits 776 length
	/// </summary>
	SKEIN1024_776 = 0xb3c1,

	/// <summary>
	/// Skein 1024 bits 784 length
	/// </summary>
	SKEIN1024_784 = 0xb3c2,

	/// <summary>
	/// Skein 1024 bits 792 length
	/// </summary>
	SKEIN1024_792 = 0xb3c3,

	/// <summary>
	/// Skein 1024 bits 800 length
	/// </summary>
	SKEIN1024_800 = 0xb3c4,

	/// <summary>
	/// Skein 1024 bits 808 length
	/// </summary>
	SKEIN1024_808 = 0xb3c5,

	/// <summary>
	/// Skein 1024 bits 816 length
	/// </summary>
	SKEIN1024_816 = 0xb3c6,

	/// <summary>
	/// Skein 1024 bits 824 length
	/// </summary>
	SKEIN1024_824 = 0xb3c7,

	/// <summary>
	/// Skein 1024 bits 832 length
	/// </summary>
	SKEIN1024_832 = 0xb3c8,

	/// <summary>
	/// Skein 1024 bits 840 length
	/// </summary>
	SKEIN1024_840 = 0xb3c9,

	/// <summary>
	/// Skein 1024 bits 848 length
	/// </summary>
	SKEIN1024_848 = 0xb3ca,

	/// <summary>
	/// Skein 1024 bits 856 length
	/// </summary>
	SKEIN1024_856 = 0xb3cb,

	/// <summary>
	/// Skein 1024 bits 864 length
	/// </summary>
	SKEIN1024_864 = 0xb3cc,

	/// <summary>
	/// Skein 1024 bits 872 length
	/// </summary>
	SKEIN1024_872 = 0xb3cd,

	/// <summary>
	/// Skein 1024 bits 880 length
	/// </summary>
	SKEIN1024_880 = 0xb3ce,

	/// <summary>
	/// Skein 1024 bits 888 length
	/// </summary>
	SKEIN1024_888 = 0xb3cf,

	/// <summary>
	/// Skein 1024 bits 896 length
	/// </summary>
	SKEIN1024_896 = 0xb3d0,

	/// <summary>
	/// Skein 1024 bits 904 length
	/// </summary>
	SKEIN1024_904 = 0xb3d1,

	/// <summary>
	/// Skein 1024 bits 912 length
	/// </summary>
	SKEIN1024_912 = 0xb3d2,

	/// <summary>
	/// Skein 1024 bits 920 length
	/// </summary>
	SKEIN1024_920 = 0xb3d3,

	/// <summary>
	/// Skein 1024 bits 928 length
	/// </summary>
	SKEIN1024_928 = 0xb3d4,

	/// <summary>
	/// Skein 1024 bits 936 length
	/// </summary>
	SKEIN1024_936 = 0xb3d5,

	/// <summary>
	/// Skein 1024 bits 944 length
	/// </summary>
	SKEIN1024_944 = 0xb3d6,

	/// <summary>
	/// Skein 1024 bits 952 length
	/// </summary>
	SKEIN1024_952 = 0xb3d7,

	/// <summary>
	/// Skein 1024 bits 960 length
	/// </summary>
	SKEIN1024_960 = 0xb3d8,

	/// <summary>
	/// Skein 1024 bits 968 length
	/// </summary>
	SKEIN1024_968 = 0xb3d9,

	/// <summary>
	/// Skein 1024 bits 976 length
	/// </summary>
	SKEIN1024_976 = 0xb3da,

	/// <summary>
	/// Skein 1024 bits 984 length
	/// </summary>
	SKEIN1024_984 = 0xb3db,

	/// <summary>
	/// Skein 1024 bits 992 length
	/// </summary>
	SKEIN1024_992 = 0xb3dc,

	/// <summary>
	/// Skein 1024 bits 1000 length
	/// </summary>
	SKEIN1024_1000 = 0xb3dd,

	/// <summary>
	/// Skein 1024 bits 1008 length
	/// </summary>
	SKEIN1024_1008 = 0xb3de,

	/// <summary>
	/// Skein 1024 bits 1016 length
	/// </summary>
	SKEIN1024_1016 = 0xb3df,

	/// <summary>
	/// Skein 1024 bits 1024 length
	/// </summary>
	SKEIN1024_1024 = 0xb3e0,

	/// <summary>
	/// Double SHA2 256 bit
	/// </summary>
	DBL_SHA2_256 = 0x56
}
