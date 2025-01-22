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
	// Token: 0x02000753 RID: 1875
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeTaxCollectorEquipmentStartedEvent : IMessage<ExchangeTaxCollectorEquipmentStartedEvent>, IMessage, IEquatable<ExchangeTaxCollectorEquipmentStartedEvent>, IDeepCloneable<ExchangeTaxCollectorEquipmentStartedEvent>, IBufferMessage
	{
		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06005C03 RID: 23555 RVA: 0x0021AAEC File Offset: 0x00218CEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeTaxCollectorEquipmentStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06005C04 RID: 23556 RVA: 0x0021AAFC File Offset: 0x00218CFC
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

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06005C05 RID: 23557 RVA: 0x0021AB0C File Offset: 0x00218D0C
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

		// Token: 0x06005C06 RID: 23558 RVA: 0x0021AB1C File Offset: 0x00218D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorEquipmentStartedEvent()
		{
		}

		// Token: 0x06005C07 RID: 23559 RVA: 0x0021AB2C File Offset: 0x00218D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorEquipmentStartedEvent(ExchangeTaxCollectorEquipmentStartedEvent other)
		{
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x0021AB3C File Offset: 0x00218D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorEquipmentStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06005C09 RID: 23561 RVA: 0x0021AB4C File Offset: 0x00218D4C
		// (set) Token: 0x06005C0A RID: 23562 RVA: 0x0021AB5C File Offset: 0x00218D5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public TaxCollectorInformation TaxCollectorInformation
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

		// Token: 0x06005C0B RID: 23563 RVA: 0x0021AB6C File Offset: 0x00218D6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x0021AB7C File Offset: 0x00218D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeTaxCollectorEquipmentStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x0021AB8C File Offset: 0x00218D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005C0E RID: 23566 RVA: 0x0021AB9C File Offset: 0x00218D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005C0F RID: 23567 RVA: 0x0021ABAC File Offset: 0x00218DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005C10 RID: 23568 RVA: 0x0021ABBC File Offset: 0x00218DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005C11 RID: 23569 RVA: 0x0021ABCC File Offset: 0x00218DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005C12 RID: 23570 RVA: 0x0021ABDC File Offset: 0x00218DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeTaxCollectorEquipmentStartedEvent other)
		{
		}

		// Token: 0x06005C13 RID: 23571 RVA: 0x0021ABEC File Offset: 0x00218DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005C14 RID: 23572 RVA: 0x0021ABFC File Offset: 0x00218DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005C15 RID: 23573 RVA: 0x0021AC0C File Offset: 0x00218E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeTaxCollectorEquipmentStartedEvent()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					ExchangeTaxCollectorEquipmentStartedEvent._parser = new MessageParser<ExchangeTaxCollectorEquipmentStartedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06005C16 RID: 23574 RVA: 0x0021ACD8 File Offset: 0x00218ED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J1KrCiOZmgpUOPcA81yc()
		{
			return true;
		}

		// Token: 0x06005C17 RID: 23575 RVA: 0x0021ACE0 File Offset: 0x00218EE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeTaxCollectorEquipmentStartedEvent ofyODHOZA4KxDVHaOcfx()
		{
			return null;
		}

		// Token: 0x04002044 RID: 8260
		private static readonly MessageParser<ExchangeTaxCollectorEquipmentStartedEvent> _parser;

		// Token: 0x04002045 RID: 8261
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002046 RID: 8262
		public const int TaxCollectorInformationFieldNumber = 1;

		// Token: 0x04002047 RID: 8263
		private TaxCollectorInformation taxCollectorInformation_;

		// Token: 0x04002048 RID: 8264
		private static ExchangeTaxCollectorEquipmentStartedEvent SafhYeOZnqD6o6PKFVtG;
	}
}
