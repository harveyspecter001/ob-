using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000729 RID: 1833
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMultiCraftCrafterCanUseHisResourcesEvent : IMessage<ExchangeMultiCraftCrafterCanUseHisResourcesEvent>, IMessage, IEquatable<ExchangeMultiCraftCrafterCanUseHisResourcesEvent>, IDeepCloneable<ExchangeMultiCraftCrafterCanUseHisResourcesEvent>, IBufferMessage
	{
		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x060059CC RID: 22988 RVA: 0x00217DE0 File Offset: 0x00215FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeMultiCraftCrafterCanUseHisResourcesEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x060059CD RID: 22989 RVA: 0x00217DF0 File Offset: 0x00215FF0
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

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x060059CE RID: 22990 RVA: 0x00217E00 File Offset: 0x00216000
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

		// Token: 0x060059CF RID: 22991 RVA: 0x00217E10 File Offset: 0x00216010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftCrafterCanUseHisResourcesEvent()
		{
		}

		// Token: 0x060059D0 RID: 22992 RVA: 0x00217E20 File Offset: 0x00216020
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftCrafterCanUseHisResourcesEvent(ExchangeMultiCraftCrafterCanUseHisResourcesEvent other)
		{
		}

		// Token: 0x060059D1 RID: 22993 RVA: 0x00217E30 File Offset: 0x00216030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftCrafterCanUseHisResourcesEvent Clone()
		{
			return null;
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x060059D2 RID: 22994 RVA: 0x00217E40 File Offset: 0x00216040
		// (set) Token: 0x060059D3 RID: 22995 RVA: 0x00217E50 File Offset: 0x00216050
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Allowed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060059D4 RID: 22996 RVA: 0x00217E60 File Offset: 0x00216060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060059D5 RID: 22997 RVA: 0x00217E70 File Offset: 0x00216070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMultiCraftCrafterCanUseHisResourcesEvent other)
		{
			return true;
		}

		// Token: 0x060059D6 RID: 22998 RVA: 0x00217E80 File Offset: 0x00216080
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x00217E90 File Offset: 0x00216090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060059D8 RID: 23000 RVA: 0x00217EA0 File Offset: 0x002160A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x00217EB0 File Offset: 0x002160B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x00217EC0 File Offset: 0x002160C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x00217ED0 File Offset: 0x002160D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMultiCraftCrafterCanUseHisResourcesEvent other)
		{
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x00217EE0 File Offset: 0x002160E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060059DD RID: 23005 RVA: 0x00217EF0 File Offset: 0x002160F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x00217F00 File Offset: 0x00216100
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMultiCraftCrafterCanUseHisResourcesEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ExchangeMultiCraftCrafterCanUseHisResourcesEvent._parser = new MessageParser<ExchangeMultiCraftCrafterCanUseHisResourcesEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x00217FE4 File Offset: 0x002161E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B3TUpXO8BxTrltjF8ZRS()
		{
			return true;
		}

		// Token: 0x060059E0 RID: 23008 RVA: 0x00217FEC File Offset: 0x002161EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMultiCraftCrafterCanUseHisResourcesEvent nWhb2NO8eZB6Gl9PjWUp()
		{
			return null;
		}

		// Token: 0x04001F72 RID: 8050
		private static readonly MessageParser<ExchangeMultiCraftCrafterCanUseHisResourcesEvent> _parser;

		// Token: 0x04001F73 RID: 8051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F74 RID: 8052
		public const int AllowedFieldNumber = 1;

		// Token: 0x04001F75 RID: 8053
		private bool allowed_;

		// Token: 0x04001F76 RID: 8054
		internal static ExchangeMultiCraftCrafterCanUseHisResourcesEvent trOMtbO8AfZqoxsEt0CS;
	}
}
