using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200021A RID: 538
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterPresetSetRequest : IMessage<CharacterPresetSetRequest>, IMessage, IEquatable<CharacterPresetSetRequest>, IDeepCloneable<CharacterPresetSetRequest>, IBufferMessage
	{
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x001AEAA4 File Offset: 0x001ACCA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterPresetSetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x001AEAB4 File Offset: 0x001ACCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x001AEAC4 File Offset: 0x001ACCC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x001AEAD4 File Offset: 0x001ACCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetSetRequest()
		{
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x001AEAE4 File Offset: 0x001ACCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetSetRequest(CharacterPresetSetRequest other)
		{
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x001AEAF4 File Offset: 0x001ACCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetSetRequest Clone()
		{
			return null;
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x001AEB04 File Offset: 0x001ACD04
		// (set) Token: 0x0600190C RID: 6412 RVA: 0x001AEB14 File Offset: 0x001ACD14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Uuid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x001AEB24 File Offset: 0x001ACD24
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x001AEB34 File Offset: 0x001ACD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetOrigin Origin
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x001AEB44 File Offset: 0x001ACD44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x001AEB54 File Offset: 0x001ACD54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterPresetSetRequest other)
		{
			return true;
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x001AEB64 File Offset: 0x001ACD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x001AEB74 File Offset: 0x001ACD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x001AEB84 File Offset: 0x001ACD84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x001AEB94 File Offset: 0x001ACD94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x001AEBA4 File Offset: 0x001ACDA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x001AEBB4 File Offset: 0x001ACDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterPresetSetRequest other)
		{
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x001AEBC4 File Offset: 0x001ACDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x001AEBD4 File Offset: 0x001ACDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x001AEBE4 File Offset: 0x001ACDE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterPresetSetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				CharacterPresetSetRequest._parser = new MessageParser<CharacterPresetSetRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x001AECB0 File Offset: 0x001ACEB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gsLZWdOa4uxcuZ5imcrL()
		{
			return true;
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x001AECB8 File Offset: 0x001ACEB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterPresetSetRequest bS9udoOajwYjactMXW6s()
		{
			return null;
		}

		// Token: 0x040008F0 RID: 2288
		private static readonly MessageParser<CharacterPresetSetRequest> _parser;

		// Token: 0x040008F1 RID: 2289
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008F2 RID: 2290
		public const int UuidFieldNumber = 1;

		// Token: 0x040008F3 RID: 2291
		private string uuid_;

		// Token: 0x040008F4 RID: 2292
		public const int OriginFieldNumber = 2;

		// Token: 0x040008F5 RID: 2293
		private PresetOrigin origin_;

		// Token: 0x040008F6 RID: 2294
		internal static CharacterPresetSetRequest LNcZaZOaxtlaYP9fgl86;
	}
}
