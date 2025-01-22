using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x020005AA RID: 1450
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapComplementaryBreachInformation : IMessage<MapComplementaryBreachInformation>, IMessage, IEquatable<MapComplementaryBreachInformation>, IDeepCloneable<MapComplementaryBreachInformation>, IBufferMessage
	{
		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06004602 RID: 17922 RVA: 0x001F86DC File Offset: 0x001F68DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapComplementaryBreachInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06004603 RID: 17923 RVA: 0x001F86EC File Offset: 0x001F68EC
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

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06004604 RID: 17924 RVA: 0x001F86FC File Offset: 0x001F68FC
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

		// Token: 0x06004605 RID: 17925 RVA: 0x001F870C File Offset: 0x001F690C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryBreachInformation()
		{
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x001F871C File Offset: 0x001F691C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryBreachInformation(MapComplementaryBreachInformation other)
		{
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x001F872C File Offset: 0x001F692C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryBreachInformation Clone()
		{
			return null;
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06004608 RID: 17928 RVA: 0x001F873C File Offset: 0x001F693C
		// (set) Token: 0x06004609 RID: 17929 RVA: 0x001F874C File Offset: 0x001F694C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Floor
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

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x0600460A RID: 17930 RVA: 0x001F875C File Offset: 0x001F695C
		// (set) Token: 0x0600460B RID: 17931 RVA: 0x001F876C File Offset: 0x001F696C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Room
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

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x0600460C RID: 17932 RVA: 0x001F877C File Offset: 0x001F697C
		// (set) Token: 0x0600460D RID: 17933 RVA: 0x001F878C File Offset: 0x001F698C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int InfinityMode
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

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x0600460E RID: 17934 RVA: 0x001F879C File Offset: 0x001F699C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BreachBranch> Branches
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x001F87AC File Offset: 0x001F69AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x001F87BC File Offset: 0x001F69BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapComplementaryBreachInformation other)
		{
			return true;
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x001F87CC File Offset: 0x001F69CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x001F87DC File Offset: 0x001F69DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x001F87EC File Offset: 0x001F69EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x001F87FC File Offset: 0x001F69FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x001F880C File Offset: 0x001F6A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x001F881C File Offset: 0x001F6A1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapComplementaryBreachInformation other)
		{
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x001F882C File Offset: 0x001F6A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x001F883C File Offset: 0x001F6A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x001F884C File Offset: 0x001F6A4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapComplementaryBreachInformation()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
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
				case 5:
					MapComplementaryBreachInformation._repeated_branches_codec = FieldCodec.ForMessage<BreachBranch>(34U, gowLQumwByDIN5xLnRgU.XVInXhlssT(gowLQumwByDIN5xLnRgU.cWrmweSVyai));
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				MapComplementaryBreachInformation._parser = new MessageParser<MapComplementaryBreachInformation>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
				{
					num2 = 5;
				}
			}
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x001F8968 File Offset: 0x001F6B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EOGAfnObBrLHpMoi41A1()
		{
			return true;
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x001F8970 File Offset: 0x001F6B70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapComplementaryBreachInformation BL8W50ObefnPjXIG6ORi()
		{
			return null;
		}

		// Token: 0x04001833 RID: 6195
		private static readonly MessageParser<MapComplementaryBreachInformation> _parser;

		// Token: 0x04001834 RID: 6196
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001835 RID: 6197
		public const int FloorFieldNumber = 1;

		// Token: 0x04001836 RID: 6198
		private int floor_;

		// Token: 0x04001837 RID: 6199
		public const int RoomFieldNumber = 2;

		// Token: 0x04001838 RID: 6200
		private int room_;

		// Token: 0x04001839 RID: 6201
		public const int InfinityModeFieldNumber = 3;

		// Token: 0x0400183A RID: 6202
		private int infinityMode_;

		// Token: 0x0400183B RID: 6203
		public const int BranchesFieldNumber = 4;

		// Token: 0x0400183C RID: 6204
		private static readonly FieldCodec<BreachBranch> _repeated_branches_codec;

		// Token: 0x0400183D RID: 6205
		private readonly RepeatedField<BreachBranch> branches_;

		// Token: 0x0400183E RID: 6206
		internal static MapComplementaryBreachInformation sGJfKdObA43PYLmEwRWH;
	}
}
