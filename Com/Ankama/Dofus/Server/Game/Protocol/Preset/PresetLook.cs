using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x020001E8 RID: 488
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetLook : IMessage<PresetLook>, IMessage, IEquatable<PresetLook>, IDeepCloneable<PresetLook>, IBufferMessage
	{
		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x001ACEE0 File Offset: 0x001AB0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PresetLook> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060016C9 RID: 5833 RVA: 0x001ACEF0 File Offset: 0x001AB0F0
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

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x001ACF00 File Offset: 0x001AB100
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

		// Token: 0x060016CB RID: 5835 RVA: 0x001ACF10 File Offset: 0x001AB110
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetLook()
		{
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x001ACF20 File Offset: 0x001AB120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetLook(PresetLook other)
		{
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x001ACF30 File Offset: 0x001AB130
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetLook Clone()
		{
			return null;
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x001ACF40 File Offset: 0x001AB140
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x001ACF50 File Offset: 0x001AB150
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public EntityLook LookWithOutfit
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

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x001ACF60 File Offset: 0x001AB160
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x001ACF70 File Offset: 0x001AB170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLook LookWithoutOutfit
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

		// Token: 0x060016D2 RID: 5842 RVA: 0x001ACF80 File Offset: 0x001AB180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x001ACF90 File Offset: 0x001AB190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetLook other)
		{
			return true;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x001ACFA0 File Offset: 0x001AB1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x001ACFB0 File Offset: 0x001AB1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x001ACFC0 File Offset: 0x001AB1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x001ACFD0 File Offset: 0x001AB1D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x001ACFE0 File Offset: 0x001AB1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x001ACFF0 File Offset: 0x001AB1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetLook other)
		{
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x001AD000 File Offset: 0x001AB200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x001AD010 File Offset: 0x001AB210
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x001AD020 File Offset: 0x001AB220
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetLook()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					PresetLook._parser = new MessageParser<PresetLook>(() => null);
					num2 = 4;
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x001AD0EC File Offset: 0x001AB2EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dn5D68O17pAUlqmckiHK()
		{
			return true;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x001AD0F4 File Offset: 0x001AB2F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetLook F0EO7OO1T5nmJwCC0GqK()
		{
			return null;
		}

		// Token: 0x0400081F RID: 2079
		private static readonly MessageParser<PresetLook> _parser;

		// Token: 0x04000820 RID: 2080
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000821 RID: 2081
		public const int LookWithOutfitFieldNumber = 1;

		// Token: 0x04000822 RID: 2082
		private EntityLook lookWithOutfit_;

		// Token: 0x04000823 RID: 2083
		public const int LookWithoutOutfitFieldNumber = 2;

		// Token: 0x04000824 RID: 2084
		private EntityLook lookWithoutOutfit_;

		// Token: 0x04000825 RID: 2085
		private static PresetLook oFQ3QTO1QmZVYJ5CLEt0;
	}
}
