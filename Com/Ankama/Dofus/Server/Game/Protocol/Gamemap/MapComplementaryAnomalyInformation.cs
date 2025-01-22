using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x020005AC RID: 1452
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapComplementaryAnomalyInformation : IMessage<MapComplementaryAnomalyInformation>, IMessage, IEquatable<MapComplementaryAnomalyInformation>, IDeepCloneable<MapComplementaryAnomalyInformation>, IBufferMessage
	{
		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x001F8978 File Offset: 0x001F6B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MapComplementaryAnomalyInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06004622 RID: 17954 RVA: 0x001F8988 File Offset: 0x001F6B88
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

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x001F8998 File Offset: 0x001F6B98
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

		// Token: 0x06004624 RID: 17956 RVA: 0x001F89A8 File Offset: 0x001F6BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryAnomalyInformation()
		{
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x001F89B8 File Offset: 0x001F6BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryAnomalyInformation(MapComplementaryAnomalyInformation other)
		{
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x001F89C8 File Offset: 0x001F6BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryAnomalyInformation Clone()
		{
			return null;
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06004627 RID: 17959 RVA: 0x001F89D8 File Offset: 0x001F6BD8
		// (set) Token: 0x06004628 RID: 17960 RVA: 0x001F89E8 File Offset: 0x001F6BE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Level
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

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06004629 RID: 17961 RVA: 0x001F89F8 File Offset: 0x001F6BF8
		// (set) Token: 0x0600462A RID: 17962 RVA: 0x001F8A08 File Offset: 0x001F6C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ClosingTime
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

		// Token: 0x0600462B RID: 17963 RVA: 0x001F8A18 File Offset: 0x001F6C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x001F8A28 File Offset: 0x001F6C28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapComplementaryAnomalyInformation other)
		{
			return true;
		}

		// Token: 0x0600462D RID: 17965 RVA: 0x001F8A38 File Offset: 0x001F6C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x001F8A48 File Offset: 0x001F6C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x001F8A58 File Offset: 0x001F6C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x001F8A68 File Offset: 0x001F6C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x001F8A78 File Offset: 0x001F6C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x001F8A88 File Offset: 0x001F6C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapComplementaryAnomalyInformation other)
		{
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x001F8A98 File Offset: 0x001F6C98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x001F8AA8 File Offset: 0x001F6CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x001F8AB8 File Offset: 0x001F6CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapComplementaryAnomalyInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_B0;
					case 4:
						return;
					}
					break;
				}
				IL_5F:
				MapComplementaryAnomalyInformation._parser = new MessageParser<MapComplementaryAnomalyInformation>(() => null);
				num = 4;
				continue;
				IL_B0:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
				continue;
				goto IL_5F;
			}
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x001F8B8C File Offset: 0x001F6D8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DRQnm8ObR5xwhXovFyeD()
		{
			return true;
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x001F8B94 File Offset: 0x001F6D94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapComplementaryAnomalyInformation epXiVEObOPAm3NJRGq08()
		{
			return null;
		}

		// Token: 0x04001841 RID: 6209
		private static readonly MessageParser<MapComplementaryAnomalyInformation> _parser;

		// Token: 0x04001842 RID: 6210
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001843 RID: 6211
		public const int LevelFieldNumber = 1;

		// Token: 0x04001844 RID: 6212
		private int level_;

		// Token: 0x04001845 RID: 6213
		public const int ClosingTimeFieldNumber = 2;

		// Token: 0x04001846 RID: 6214
		private long closingTime_;

		// Token: 0x04001847 RID: 6215
		internal static MapComplementaryAnomalyInformation Ji0wCgOb3QOEkueZpdNa;
	}
}
