using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x020001F1 RID: 497
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Equipment : IMessage<Equipment>, IMessage, IEquatable<Equipment>, IDeepCloneable<Equipment>, IBufferMessage
	{
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x001AD324 File Offset: 0x001AB524
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Equipment> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x001AD334 File Offset: 0x001AB534
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x001AD344 File Offset: 0x001AB544
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

		// Token: 0x06001743 RID: 5955 RVA: 0x001AD354 File Offset: 0x001AB554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Equipment()
		{
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x001AD364 File Offset: 0x001AB564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Equipment(Equipment other)
		{
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x001AD374 File Offset: 0x001AB574
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Equipment Clone()
		{
			return null;
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x001AD384 File Offset: 0x001AB584
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x001AD394 File Offset: 0x001AB594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Gid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x001AD3A4 File Offset: 0x001AB5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectEffect> Effects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x001AD3B4 File Offset: 0x001AB5B4
		// (set) Token: 0x0600174A RID: 5962 RVA: 0x001AD3C4 File Offset: 0x001AB5C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Uid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x001AD3D4 File Offset: 0x001AB5D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x001AD3E4 File Offset: 0x001AB5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearUid()
		{
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x001AD3F4 File Offset: 0x001AB5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x001AD404 File Offset: 0x001AB604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Equipment other)
		{
			return true;
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x001AD414 File Offset: 0x001AB614
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x001AD424 File Offset: 0x001AB624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x001AD434 File Offset: 0x001AB634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x001AD444 File Offset: 0x001AB644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x001AD454 File Offset: 0x001AB654
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x001AD464 File Offset: 0x001AB664
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Equipment other)
		{
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x001AD474 File Offset: 0x001AB674
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x001AD484 File Offset: 0x001AB684
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x001AD494 File Offset: 0x001AB694
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Equipment()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						Equipment.UidDefaultValue = 0;
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 6;
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						Equipment._parser = new MessageParser<Equipment>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 6:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					}
					break;
				}
				IL_102:
				Equipment._repeated_effects_codec = FieldCodec.ForMessage<ObjectEffect>(26U, P1SsVKnf4KAo6qkGT9ff.XVInXhlssT(P1SsVKnf4KAo6qkGT9ff.HVGnfjmP83g));
				num = 2;
				continue;
				goto IL_102;
			}
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x001AD5C8 File Offset: 0x001AB7C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dH1ZSWO1iZ6nvNWWpuWJ()
		{
			return true;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x001AD5D0 File Offset: 0x001AB7D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Equipment LdcKnjO1PMWVxy2JWyQk()
		{
			return null;
		}

		// Token: 0x0400084C RID: 2124
		private static readonly MessageParser<Equipment> _parser;

		// Token: 0x0400084D RID: 2125
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400084E RID: 2126
		private int _hasBits0;

		// Token: 0x0400084F RID: 2127
		public const int GidFieldNumber = 1;

		// Token: 0x04000850 RID: 2128
		private int gid_;

		// Token: 0x04000851 RID: 2129
		public const int EffectsFieldNumber = 3;

		// Token: 0x04000852 RID: 2130
		private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

		// Token: 0x04000853 RID: 2131
		private readonly RepeatedField<ObjectEffect> effects_;

		// Token: 0x04000854 RID: 2132
		public const int UidFieldNumber = 2;

		// Token: 0x04000855 RID: 2133
		private static readonly int UidDefaultValue;

		// Token: 0x04000856 RID: 2134
		private int uid_;

		// Token: 0x04000857 RID: 2135
		internal static Equipment RxZBfeO1bsna3vwrIQAQ;
	}
}
