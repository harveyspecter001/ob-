using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200071F RID: 1823
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectPutInBagEvent : IMessage<ExchangeObjectPutInBagEvent>, IMessage, IEquatable<ExchangeObjectPutInBagEvent>, IDeepCloneable<ExchangeObjectPutInBagEvent>, IBufferMessage
	{
		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x0600593E RID: 22846 RVA: 0x002172C0 File Offset: 0x002154C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectPutInBagEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x0600593F RID: 22847 RVA: 0x002172D0 File Offset: 0x002154D0
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

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06005940 RID: 22848 RVA: 0x002172E0 File Offset: 0x002154E0
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

		// Token: 0x06005941 RID: 22849 RVA: 0x002172F0 File Offset: 0x002154F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectPutInBagEvent()
		{
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x00217300 File Offset: 0x00215500
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectPutInBagEvent(ExchangeObjectPutInBagEvent other)
		{
		}

		// Token: 0x06005943 RID: 22851 RVA: 0x00217310 File Offset: 0x00215510
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectPutInBagEvent Clone()
		{
			return null;
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06005944 RID: 22852 RVA: 0x00217320 File Offset: 0x00215520
		// (set) Token: 0x06005945 RID: 22853 RVA: 0x00217330 File Offset: 0x00215530
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Remote
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

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06005946 RID: 22854 RVA: 0x00217340 File Offset: 0x00215540
		// (set) Token: 0x06005947 RID: 22855 RVA: 0x00217350 File Offset: 0x00215550
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectItemInventory Object
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

		// Token: 0x06005948 RID: 22856 RVA: 0x00217360 File Offset: 0x00215560
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x00217370 File Offset: 0x00215570
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectPutInBagEvent other)
		{
			return true;
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x00217380 File Offset: 0x00215580
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x00217390 File Offset: 0x00215590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x002173A0 File Offset: 0x002155A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x002173B0 File Offset: 0x002155B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x002173C0 File Offset: 0x002155C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x002173D0 File Offset: 0x002155D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectPutInBagEvent other)
		{
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x002173E0 File Offset: 0x002155E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x002173F0 File Offset: 0x002155F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x00217400 File Offset: 0x00215600
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectPutInBagEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					ExchangeObjectPutInBagEvent._parser = new MessageParser<ExchangeObjectPutInBagEvent>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x002174E4 File Offset: 0x002156E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oHETq4Oub7TNZTmE90h7()
		{
			return true;
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x002174EC File Offset: 0x002156EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectPutInBagEvent tVme8yOuiLWKgoCEfcfE()
		{
			return null;
		}

		// Token: 0x04001F43 RID: 8003
		private static readonly MessageParser<ExchangeObjectPutInBagEvent> _parser;

		// Token: 0x04001F44 RID: 8004
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F45 RID: 8005
		public const int RemoteFieldNumber = 1;

		// Token: 0x04001F46 RID: 8006
		private bool remote_;

		// Token: 0x04001F47 RID: 8007
		public const int ObjectFieldNumber = 2;

		// Token: 0x04001F48 RID: 8008
		private ObjectItemInventory object_;

		// Token: 0x04001F49 RID: 8009
		internal static ExchangeObjectPutInBagEvent HA63qWOuYwqRbBAnDUQ9;
	}
}
