using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A7D RID: 2685
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EntityLook : IMessage<EntityLook>, IMessage, IEquatable<EntityLook>, IDeepCloneable<EntityLook>, IBufferMessage
	{
		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x0600803C RID: 32828 RVA: 0x0025F9CC File Offset: 0x0025DBCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<EntityLook> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x0600803D RID: 32829 RVA: 0x0025F9DC File Offset: 0x0025DBDC
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

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x0600803E RID: 32830 RVA: 0x0025F9EC File Offset: 0x0025DBEC
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

		// Token: 0x0600803F RID: 32831 RVA: 0x0025F9FC File Offset: 0x0025DBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntityLook()
		{
		}

		// Token: 0x06008040 RID: 32832 RVA: 0x0025FA0C File Offset: 0x0025DC0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntityLook(EntityLook other)
		{
		}

		// Token: 0x06008041 RID: 32833 RVA: 0x0025FA1C File Offset: 0x0025DC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntityLook Clone()
		{
			return null;
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06008042 RID: 32834 RVA: 0x0025FA2C File Offset: 0x0025DC2C
		// (set) Token: 0x06008043 RID: 32835 RVA: 0x0025FA3C File Offset: 0x0025DC3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int BonesId
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

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06008044 RID: 32836 RVA: 0x0025FA4C File Offset: 0x0025DC4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> Skins
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06008045 RID: 32837 RVA: 0x0025FA5C File Offset: 0x0025DC5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> IndexedColors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06008046 RID: 32838 RVA: 0x0025FA6C File Offset: 0x0025DC6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> Scales
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06008047 RID: 32839 RVA: 0x0025FA7C File Offset: 0x0025DC7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<SubEntityInformation> SubEntities
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06008048 RID: 32840 RVA: 0x0025FA8C File Offset: 0x0025DC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008049 RID: 32841 RVA: 0x0025FA9C File Offset: 0x0025DC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EntityLook other)
		{
			return true;
		}

		// Token: 0x0600804A RID: 32842 RVA: 0x0025FAAC File Offset: 0x0025DCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600804B RID: 32843 RVA: 0x0025FABC File Offset: 0x0025DCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600804C RID: 32844 RVA: 0x0025FACC File Offset: 0x0025DCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600804D RID: 32845 RVA: 0x0025FADC File Offset: 0x0025DCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600804E RID: 32846 RVA: 0x0025FAEC File Offset: 0x0025DCEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600804F RID: 32847 RVA: 0x0025FAFC File Offset: 0x0025DCFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(EntityLook other)
		{
		}

		// Token: 0x06008050 RID: 32848 RVA: 0x0025FB0C File Offset: 0x0025DD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008051 RID: 32849 RVA: 0x0025FB1C File Offset: 0x0025DD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008052 RID: 32850 RVA: 0x0025FB2C File Offset: 0x0025DD2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EntityLook()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 8;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					EntityLook._parser = new MessageParser<EntityLook>(() => null);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					EntityLook._repeated_subEntities_codec = FieldCodec.ForMessage<SubEntityInformation>(42U, yS8GoRBIfRAyv3KFYUTw.XVInXhlssT(yS8GoRBIfRAyv3KFYUTw.ahSBIn2kbj0));
					num2 = 6;
					continue;
				case 4:
					EntityLook._repeated_indexedColors_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(26U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					EntityLook._repeated_skins_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 6:
					return;
				case 7:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 8:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
					{
						num2 = 7;
						continue;
					}
					continue;
				}
				EntityLook._repeated_scales_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(34U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06008053 RID: 32851 RVA: 0x0025FCD0 File Offset: 0x0025DED0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Er539xJggxTYNtLR2g1C()
		{
			return true;
		}

		// Token: 0x06008054 RID: 32852 RVA: 0x0025FCD8 File Offset: 0x0025DED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EntityLook UqP5dEJgsRC5CIy9gRc2()
		{
			return null;
		}

		// Token: 0x04002E82 RID: 11906
		private static readonly MessageParser<EntityLook> _parser;

		// Token: 0x04002E83 RID: 11907
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E84 RID: 11908
		public const int BonesIdFieldNumber = 1;

		// Token: 0x04002E85 RID: 11909
		private int bonesId_;

		// Token: 0x04002E86 RID: 11910
		public const int SkinsFieldNumber = 2;

		// Token: 0x04002E87 RID: 11911
		private static readonly FieldCodec<int> _repeated_skins_codec;

		// Token: 0x04002E88 RID: 11912
		private readonly RepeatedField<int> skins_;

		// Token: 0x04002E89 RID: 11913
		public const int IndexedColorsFieldNumber = 3;

		// Token: 0x04002E8A RID: 11914
		private static readonly FieldCodec<int> _repeated_indexedColors_codec;

		// Token: 0x04002E8B RID: 11915
		private readonly RepeatedField<int> indexedColors_;

		// Token: 0x04002E8C RID: 11916
		public const int ScalesFieldNumber = 4;

		// Token: 0x04002E8D RID: 11917
		private static readonly FieldCodec<int> _repeated_scales_codec;

		// Token: 0x04002E8E RID: 11918
		private readonly RepeatedField<int> scales_;

		// Token: 0x04002E8F RID: 11919
		public const int SubEntitiesFieldNumber = 5;

		// Token: 0x04002E90 RID: 11920
		private static readonly FieldCodec<SubEntityInformation> _repeated_subEntities_codec;

		// Token: 0x04002E91 RID: 11921
		private readonly RepeatedField<SubEntityInformation> subEntities_;

		// Token: 0x04002E92 RID: 11922
		private static EntityLook D1SQKWJgGtuHPCMNLR7W;
	}
}
