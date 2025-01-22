using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000226 RID: 550
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterPresetResetRequest : IMessage<CharacterPresetResetRequest>, IMessage, IEquatable<CharacterPresetResetRequest>, IDeepCloneable<CharacterPresetResetRequest>, IBufferMessage
	{
		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x001AF790 File Offset: 0x001AD990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterPresetResetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x001AF7A0 File Offset: 0x001AD9A0
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

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x001AF7B0 File Offset: 0x001AD9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x001AF7C0 File Offset: 0x001AD9C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetResetRequest()
		{
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x001AF7D0 File Offset: 0x001AD9D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetResetRequest(CharacterPresetResetRequest other)
		{
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x001AF7E0 File Offset: 0x001AD9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetResetRequest Clone()
		{
			return null;
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x001AF7F0 File Offset: 0x001AD9F0
		// (set) Token: 0x060019B2 RID: 6578 RVA: 0x001AF800 File Offset: 0x001ADA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x060019B3 RID: 6579 RVA: 0x001AF810 File Offset: 0x001ADA10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x001AF820 File Offset: 0x001ADA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterPresetResetRequest other)
		{
			return true;
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x001AF830 File Offset: 0x001ADA30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x001AF840 File Offset: 0x001ADA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x001AF850 File Offset: 0x001ADA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x001AF860 File Offset: 0x001ADA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x001AF870 File Offset: 0x001ADA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x001AF880 File Offset: 0x001ADA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterPresetResetRequest other)
		{
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x001AF890 File Offset: 0x001ADA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x001AF8A0 File Offset: 0x001ADAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x001AF8B0 File Offset: 0x001ADAB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterPresetResetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					break;
				case 1:
					return;
				case 2:
					CharacterPresetResetRequest._parser = new MessageParser<CharacterPresetResetRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x001AF97C File Offset: 0x001ADB7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d6vv0gOarvxP1CFeBD68()
		{
			return true;
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x001AF984 File Offset: 0x001ADB84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterPresetResetRequest ynlNiIOaVlrFUmJhtgg1()
		{
			return null;
		}

		// Token: 0x04000924 RID: 2340
		private static readonly MessageParser<CharacterPresetResetRequest> _parser;

		// Token: 0x04000925 RID: 2341
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000926 RID: 2342
		public const int UuidFieldNumber = 1;

		// Token: 0x04000927 RID: 2343
		private string uuid_;

		// Token: 0x04000928 RID: 2344
		private static CharacterPresetResetRequest OEZw9BOahw1blM6CHXix;
	}
}
