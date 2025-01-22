using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A83 RID: 2691
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EntityDisposition : IMessage<EntityDisposition>, IMessage, IEquatable<EntityDisposition>, IDeepCloneable<EntityDisposition>, IBufferMessage
	{
		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06008079 RID: 32889 RVA: 0x0025FF38 File Offset: 0x0025E138
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<EntityDisposition> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x0600807A RID: 32890 RVA: 0x0025FF48 File Offset: 0x0025E148
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

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x0600807B RID: 32891 RVA: 0x0025FF58 File Offset: 0x0025E158
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

		// Token: 0x0600807C RID: 32892 RVA: 0x0025FF68 File Offset: 0x0025E168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntityDisposition()
		{
		}

		// Token: 0x0600807D RID: 32893 RVA: 0x0025FF78 File Offset: 0x0025E178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntityDisposition(EntityDisposition other)
		{
		}

		// Token: 0x0600807E RID: 32894 RVA: 0x0025FF88 File Offset: 0x0025E188
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntityDisposition Clone()
		{
			return null;
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x0600807F RID: 32895 RVA: 0x0025FF98 File Offset: 0x0025E198
		// (set) Token: 0x06008080 RID: 32896 RVA: 0x0025FFAC File Offset: 0x0025E1AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Direction Direction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Direction)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06008081 RID: 32897 RVA: 0x0025FFBC File Offset: 0x0025E1BC
		// (set) Token: 0x06008082 RID: 32898 RVA: 0x0025FFCC File Offset: 0x0025E1CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long EntityId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x06008083 RID: 32899 RVA: 0x0025FFDC File Offset: 0x0025E1DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasEntityId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06008084 RID: 32900 RVA: 0x0025FFEC File Offset: 0x0025E1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearEntityId()
		{
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x06008085 RID: 32901 RVA: 0x0025FFFC File Offset: 0x0025E1FC
		// (set) Token: 0x06008086 RID: 32902 RVA: 0x0026000C File Offset: 0x0025E20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CellId
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

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06008087 RID: 32903 RVA: 0x0026001C File Offset: 0x0025E21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCellId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06008088 RID: 32904 RVA: 0x0026002C File Offset: 0x0025E22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearCellId()
		{
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06008089 RID: 32905 RVA: 0x0026003C File Offset: 0x0025E23C
		// (set) Token: 0x0600808A RID: 32906 RVA: 0x0026004C File Offset: 0x0025E24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CarryingCharacterId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x0600808B RID: 32907 RVA: 0x0026005C File Offset: 0x0025E25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCarryingCharacterId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x0600808C RID: 32908 RVA: 0x0026006C File Offset: 0x0025E26C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearCarryingCharacterId()
		{
		}

		// Token: 0x0600808D RID: 32909 RVA: 0x0026007C File Offset: 0x0025E27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600808E RID: 32910 RVA: 0x0026008C File Offset: 0x0025E28C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EntityDisposition other)
		{
			return true;
		}

		// Token: 0x0600808F RID: 32911 RVA: 0x0026009C File Offset: 0x0025E29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008090 RID: 32912 RVA: 0x002600AC File Offset: 0x0025E2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008091 RID: 32913 RVA: 0x002600BC File Offset: 0x0025E2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008092 RID: 32914 RVA: 0x002600CC File Offset: 0x0025E2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008093 RID: 32915 RVA: 0x002600DC File Offset: 0x0025E2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x002600EC File Offset: 0x0025E2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(EntityDisposition other)
		{
		}

		// Token: 0x06008095 RID: 32917 RVA: 0x002600FC File Offset: 0x0025E2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008096 RID: 32918 RVA: 0x0026010C File Offset: 0x0025E30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x0026011C File Offset: 0x0025E31C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EntityDisposition()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					EntityDisposition.CellIdDefaultValue = 0;
					num2 = 5;
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 7;
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					EntityDisposition._parser = new MessageParser<EntityDisposition>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 6;
					}
					break;
				case 5:
					EntityDisposition.CarryingCharacterIdDefaultValue = 0L;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					EntityDisposition.EntityIdDefaultValue = 0L;
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 1;
					}
					break;
				case 7:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				}
			}
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x0026023C File Offset: 0x0025E43C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aXNasQJgXOZNwKjBYrXR()
		{
			return true;
		}

		// Token: 0x06008099 RID: 32921 RVA: 0x00260244 File Offset: 0x0025E444
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EntityDisposition W2XBqpJgNcG2Ya6UyRdK()
		{
			return null;
		}

		// Token: 0x04002EA8 RID: 11944
		private static readonly MessageParser<EntityDisposition> _parser;

		// Token: 0x04002EA9 RID: 11945
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EAA RID: 11946
		private int _hasBits0;

		// Token: 0x04002EAB RID: 11947
		public const int DirectionFieldNumber = 3;

		// Token: 0x04002EAC RID: 11948
		private Direction direction_;

		// Token: 0x04002EAD RID: 11949
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04002EAE RID: 11950
		private static readonly long EntityIdDefaultValue;

		// Token: 0x04002EAF RID: 11951
		private long entityId_;

		// Token: 0x04002EB0 RID: 11952
		public const int CellIdFieldNumber = 2;

		// Token: 0x04002EB1 RID: 11953
		private static readonly int CellIdDefaultValue;

		// Token: 0x04002EB2 RID: 11954
		private int cellId_;

		// Token: 0x04002EB3 RID: 11955
		public const int CarryingCharacterIdFieldNumber = 4;

		// Token: 0x04002EB4 RID: 11956
		private static readonly long CarryingCharacterIdDefaultValue;

		// Token: 0x04002EB5 RID: 11957
		private long carryingCharacterId_;

		// Token: 0x04002EB6 RID: 11958
		private static EntityDisposition EsXIYbJgEQvKqEwAHK9x;
	}
}
