﻿using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Client
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Queries
        : global::StrawberryShake.IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            86,
            106,
            105,
            120,
            54,
            67,
            54,
            69,
            98,
            48,
            47,
            122,
            50,
            119,
            72,
            69,
            107,
            79,
            56,
            66,
            51,
            119,
            61,
            61
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            103,
            101,
            116,
            80,
            101,
            111,
            112,
            108,
            101,
            32,
            123,
            32,
            112,
            101,
            111,
            112,
            108,
            101,
            40,
            111,
            114,
            100,
            101,
            114,
            95,
            98,
            121,
            58,
            32,
            123,
            32,
            110,
            97,
            109,
            101,
            58,
            32,
            65,
            83,
            67,
            32,
            125,
            41,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            111,
            100,
            101,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            97,
            109,
            101,
            32,
            108,
            97,
            115,
            116,
            83,
            101,
            101,
            110,
            32,
            125,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query getPeople {
              people(order_by: { name: ASC }) {
                nodes {
                  name
                  lastSeen
                }
              }
            }";
    }
}
