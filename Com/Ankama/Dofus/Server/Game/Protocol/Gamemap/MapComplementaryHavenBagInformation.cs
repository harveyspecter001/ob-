using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x020005AE RID: 1454
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapComplementaryHavenBagInformation : IMessage<MapComplementaryHavenBagInformation>, IMessage, IEquatable<MapComplementaryHavenBagInformation>, IDeepCloneable<MapComplementaryHavenBagInformation>, IBufferMessage
	{
		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x0600463D RID: 17981 RVA: 0x001F8B9C File Offset: 0x001F6D9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapComplementaryHavenBagInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x0600463E RID: 17982 RVA: 0x001F8BAC File Offset: 0x001F6DAC
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

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x0600463F RID: 17983 RVA: 0x001F8BBC File Offset: 0x001F6DBC
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

		// Token: 0x06004640 RID: 17984 RVA: 0x001F8BCC File Offset: 0x001F6DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryHavenBagInformation()
		{
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x001F8BDC File Offset: 0x001F6DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryHavenBagInformation(MapComplementaryHavenBagInformation other)
		{
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x001F8BEC File Offset: 0x001F6DEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryHavenBagInformation Clone()
		{
			return null;
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06004643 RID: 17987 RVA: 0x001F8BFC File Offset: 0x001F6DFC
		// (set) Token: 0x06004644 RID: 17988 RVA: 0x001F8C0C File Offset: 0x001F6E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Character OwnerInformation
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

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06004645 RID: 17989 RVA: 0x001F8C1C File Offset: 0x001F6E1C
		// (set) Token: 0x06004646 RID: 17990 RVA: 0x001F8C2C File Offset: 0x001F6E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Theme
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

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06004647 RID: 17991 RVA: 0x001F8C3C File Offset: 0x001F6E3C
		// (set) Token: 0x06004648 RID: 17992 RVA: 0x001F8C4C File Offset: 0x001F6E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoomId
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

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06004649 RID: 17993 RVA: 0x001F8C5C File Offset: 0x001F6E5C
		// (set) Token: 0x0600464A RID: 17994 RVA: 0x001F8C6C File Offset: 0x001F6E6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MaxRoomId
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

		// Token: 0x0600464B RID: 17995 RVA: 0x001F8C7C File Offset: 0x001F6E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x001F8C8C File Offset: 0x001F6E8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapComplementaryHavenBagInformation other)
		{
			return true;
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x001F8C9C File Offset: 0x001F6E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x001F8CAC File Offset: 0x001F6EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x001F8CBC File Offset: 0x001F6EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x001F8CCC File Offset: 0x001F6ECC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x001F8CDC File Offset: 0x001F6EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x001F8CEC File Offset: 0x001F6EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapComplementaryHavenBagInformation other)
		{
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x001F8CFC File Offset: 0x001F6EFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x001F8D0C File Offset: 0x001F6F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x001F8D1C File Offset: 0x001F6F1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapComplementaryHavenBagInformation()
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
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					MapComplementaryHavenBagInformation._parser = new MessageParser<MapComplementaryHavenBagInformation>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x001F8E14 File Offset: 0x001F7014
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ek8MuyObGMSx5G71tH46()
		{
			return true;
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x001F8E1C File Offset: 0x001F701C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapComplementaryHavenBagInformation PlfwwCObgbrRCjyV6ltD()
		{
			return null;
		}

		// Token: 0x0400184A RID: 6218
		private static readonly MessageParser<MapComplementaryHavenBagInformation> _parser;

		// Token: 0x0400184B RID: 6219
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400184C RID: 6220
		public const int OwnerInformationFieldNumber = 1;

		// Token: 0x0400184D RID: 6221
		private Character ownerInformation_;

		// Token: 0x0400184E RID: 6222
		public const int ThemeFieldNumber = 2;

		// Token: 0x0400184F RID: 6223
		private int theme_;

		// Token: 0x04001850 RID: 6224
		public const int RoomIdFieldNumber = 3;

		// Token: 0x04001851 RID: 6225
		private int roomId_;

		// Token: 0x04001852 RID: 6226
		public const int MaxRoomIdFieldNumber = 4;

		// Token: 0x04001853 RID: 6227
		private int maxRoomId_;

		// Token: 0x04001854 RID: 6228
		internal static MapComplementaryHavenBagInformation MvkTnBObJPIaQ7eT96PZ;
	}
}
