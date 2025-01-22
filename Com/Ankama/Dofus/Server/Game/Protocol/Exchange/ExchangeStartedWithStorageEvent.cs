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
	// Token: 0x02000731 RID: 1841
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeStartedWithStorageEvent : IMessage<ExchangeStartedWithStorageEvent>, IMessage, IEquatable<ExchangeStartedWithStorageEvent>, IDeepCloneable<ExchangeStartedWithStorageEvent>, IBufferMessage
	{
		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06005A44 RID: 23108 RVA: 0x002186F8 File Offset: 0x002168F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeStartedWithStorageEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06005A45 RID: 23109 RVA: 0x00218708 File Offset: 0x00216908
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

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06005A46 RID: 23110 RVA: 0x00218718 File Offset: 0x00216918
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

		// Token: 0x06005A47 RID: 23111 RVA: 0x00218728 File Offset: 0x00216928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStartedWithStorageEvent()
		{
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x00218738 File Offset: 0x00216938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStartedWithStorageEvent(ExchangeStartedWithStorageEvent other)
		{
		}

		// Token: 0x06005A49 RID: 23113 RVA: 0x00218748 File Offset: 0x00216948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStartedWithStorageEvent Clone()
		{
			return null;
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06005A4A RID: 23114 RVA: 0x00218758 File Offset: 0x00216958
		// (set) Token: 0x06005A4B RID: 23115 RVA: 0x0021876C File Offset: 0x0021696C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeType ExchangeType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ExchangeType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06005A4C RID: 23116 RVA: 0x0021877C File Offset: 0x0021697C
		// (set) Token: 0x06005A4D RID: 23117 RVA: 0x0021878C File Offset: 0x0021698C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StorageMaxSlot
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

		// Token: 0x06005A4E RID: 23118 RVA: 0x0021879C File Offset: 0x0021699C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005A4F RID: 23119 RVA: 0x002187AC File Offset: 0x002169AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeStartedWithStorageEvent other)
		{
			return true;
		}

		// Token: 0x06005A50 RID: 23120 RVA: 0x002187BC File Offset: 0x002169BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x002187CC File Offset: 0x002169CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x002187DC File Offset: 0x002169DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x002187EC File Offset: 0x002169EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x002187FC File Offset: 0x002169FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005A55 RID: 23125 RVA: 0x0021880C File Offset: 0x00216A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeStartedWithStorageEvent other)
		{
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x0021881C File Offset: 0x00216A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005A57 RID: 23127 RVA: 0x0021882C File Offset: 0x00216A2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005A58 RID: 23128 RVA: 0x0021883C File Offset: 0x00216A3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeStartedWithStorageEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				ExchangeStartedWithStorageEvent._parser = new MessageParser<ExchangeStartedWithStorageEvent>(() => null);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x00218934 File Offset: 0x00216B34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zTMWClO8ENoGJQY2D7hx()
		{
			return true;
		}

		// Token: 0x06005A5A RID: 23130 RVA: 0x0021893C File Offset: 0x00216B3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeStartedWithStorageEvent dad7jIO8XYU4tNcVjEcO()
		{
			return null;
		}

		// Token: 0x04001F9E RID: 8094
		private static readonly MessageParser<ExchangeStartedWithStorageEvent> _parser;

		// Token: 0x04001F9F RID: 8095
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FA0 RID: 8096
		public const int ExchangeTypeFieldNumber = 1;

		// Token: 0x04001FA1 RID: 8097
		private ExchangeType exchangeType_;

		// Token: 0x04001FA2 RID: 8098
		public const int StorageMaxSlotFieldNumber = 2;

		// Token: 0x04001FA3 RID: 8099
		private int storageMaxSlot_;

		// Token: 0x04001FA4 RID: 8100
		internal static ExchangeStartedWithStorageEvent H9CPOUO82AVHMd7Um5Qe;
	}
}
