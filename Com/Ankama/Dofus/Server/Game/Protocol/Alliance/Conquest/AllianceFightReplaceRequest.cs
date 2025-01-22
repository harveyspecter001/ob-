using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000D85 RID: 3461
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFightReplaceRequest : IMessage<AllianceFightReplaceRequest>, IMessage, IEquatable<AllianceFightReplaceRequest>, IDeepCloneable<AllianceFightReplaceRequest>, IBufferMessage
	{
		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x0600A6D1 RID: 42705 RVA: 0x00293910 File Offset: 0x00291B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceFightReplaceRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x0600A6D2 RID: 42706 RVA: 0x00293920 File Offset: 0x00291B20
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

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x0600A6D3 RID: 42707 RVA: 0x00293930 File Offset: 0x00291B30
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

		// Token: 0x0600A6D4 RID: 42708 RVA: 0x00293940 File Offset: 0x00291B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightReplaceRequest()
		{
		}

		// Token: 0x0600A6D5 RID: 42709 RVA: 0x00293950 File Offset: 0x00291B50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightReplaceRequest(AllianceFightReplaceRequest other)
		{
		}

		// Token: 0x0600A6D6 RID: 42710 RVA: 0x00293960 File Offset: 0x00291B60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightReplaceRequest Clone()
		{
			return null;
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x0600A6D7 RID: 42711 RVA: 0x00293970 File Offset: 0x00291B70
		// (set) Token: 0x0600A6D8 RID: 42712 RVA: 0x00293980 File Offset: 0x00291B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialFightInformation FightInformation
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

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x0600A6D9 RID: 42713 RVA: 0x00293990 File Offset: 0x00291B90
		// (set) Token: 0x0600A6DA RID: 42714 RVA: 0x002939A0 File Offset: 0x00291BA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long ToReplaceFighterId
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

		// Token: 0x0600A6DB RID: 42715 RVA: 0x002939B0 File Offset: 0x00291BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A6DC RID: 42716 RVA: 0x002939C0 File Offset: 0x00291BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFightReplaceRequest other)
		{
			return true;
		}

		// Token: 0x0600A6DD RID: 42717 RVA: 0x002939D0 File Offset: 0x00291BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A6DE RID: 42718 RVA: 0x002939E0 File Offset: 0x00291BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A6DF RID: 42719 RVA: 0x002939F0 File Offset: 0x00291BF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A6E0 RID: 42720 RVA: 0x00293A00 File Offset: 0x00291C00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A6E1 RID: 42721 RVA: 0x00293A10 File Offset: 0x00291C10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A6E2 RID: 42722 RVA: 0x00293A20 File Offset: 0x00291C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFightReplaceRequest other)
		{
		}

		// Token: 0x0600A6E3 RID: 42723 RVA: 0x00293A30 File Offset: 0x00291C30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A6E4 RID: 42724 RVA: 0x00293A40 File Offset: 0x00291C40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A6E5 RID: 42725 RVA: 0x00293A50 File Offset: 0x00291C50
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFightReplaceRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						AllianceFightReplaceRequest._parser = new MessageParser<AllianceFightReplaceRequest>(() => null);
						num2 = 3;
						continue;
					}
					break;
				}
				IL_83:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
				continue;
				goto IL_83;
			}
		}

		// Token: 0x0600A6E6 RID: 42726 RVA: 0x00293B20 File Offset: 0x00291D20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Sl3jtnJlBcn8W885WZhl()
		{
			return true;
		}

		// Token: 0x0600A6E7 RID: 42727 RVA: 0x00293B28 File Offset: 0x00291D28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFightReplaceRequest DxPTNTJlep5V6EdH0iyh()
		{
			return null;
		}

		// Token: 0x04003D68 RID: 15720
		private static readonly MessageParser<AllianceFightReplaceRequest> _parser;

		// Token: 0x04003D69 RID: 15721
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D6A RID: 15722
		public const int FightInformationFieldNumber = 1;

		// Token: 0x04003D6B RID: 15723
		private SocialFightInformation fightInformation_;

		// Token: 0x04003D6C RID: 15724
		public const int ToReplaceFighterIdFieldNumber = 2;

		// Token: 0x04003D6D RID: 15725
		private long toReplaceFighterId_;

		// Token: 0x04003D6E RID: 15726
		internal static AllianceFightReplaceRequest Py243QJlALRCIas2KlKL;
	}
}
