using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200078D RID: 1933
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMountsPaddockAddedEvent : IMessage<ExchangeMountsPaddockAddedEvent>, IMessage, IEquatable<ExchangeMountsPaddockAddedEvent>, IDeepCloneable<ExchangeMountsPaddockAddedEvent>, IBufferMessage
	{
		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06005ECE RID: 24270 RVA: 0x0021DAEC File Offset: 0x0021BCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeMountsPaddockAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06005ECF RID: 24271 RVA: 0x0021DAFC File Offset: 0x0021BCFC
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

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06005ED0 RID: 24272 RVA: 0x0021DB0C File Offset: 0x0021BD0C
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

		// Token: 0x06005ED1 RID: 24273 RVA: 0x0021DB1C File Offset: 0x0021BD1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountsPaddockAddedEvent()
		{
		}

		// Token: 0x06005ED2 RID: 24274 RVA: 0x0021DB2C File Offset: 0x0021BD2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountsPaddockAddedEvent(ExchangeMountsPaddockAddedEvent other)
		{
		}

		// Token: 0x06005ED3 RID: 24275 RVA: 0x0021DB3C File Offset: 0x0021BD3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountsPaddockAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06005ED4 RID: 24276 RVA: 0x0021DB4C File Offset: 0x0021BD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MountData> Mounts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x0021DB5C File Offset: 0x0021BD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x0021DB6C File Offset: 0x0021BD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMountsPaddockAddedEvent other)
		{
			return true;
		}

		// Token: 0x06005ED7 RID: 24279 RVA: 0x0021DB7C File Offset: 0x0021BD7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x0021DB8C File Offset: 0x0021BD8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005ED9 RID: 24281 RVA: 0x0021DB9C File Offset: 0x0021BD9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005EDA RID: 24282 RVA: 0x0021DBAC File Offset: 0x0021BDAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x0021DBBC File Offset: 0x0021BDBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x0021DBCC File Offset: 0x0021BDCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMountsPaddockAddedEvent other)
		{
		}

		// Token: 0x06005EDD RID: 24285 RVA: 0x0021DBDC File Offset: 0x0021BDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x0021DBEC File Offset: 0x0021BDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005EDF RID: 24287 RVA: 0x0021DBFC File Offset: 0x0021BDFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMountsPaddockAddedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					return;
				case 4:
					ExchangeMountsPaddockAddedEvent._parser = new MessageParser<ExchangeMountsPaddockAddedEvent>(() => null);
					num2 = 5;
					break;
				case 5:
					ExchangeMountsPaddockAddedEvent._repeated_mounts_codec = FieldCodec.ForMessage<MountData>(10U, uZWv2vA6viUJSmHpxF4k.XVInXhlssT(uZWv2vA6viUJSmHpxF4k.zN6A6oXMqvt));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x06005EE0 RID: 24288 RVA: 0x0021DD18 File Offset: 0x0021BF18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool APr4ckOqAlRhmOZmqDi8()
		{
			return true;
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x0021DD20 File Offset: 0x0021BF20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMountsPaddockAddedEvent cpuov5OqBWVbgUSS4cBE()
		{
			return null;
		}

		// Token: 0x04002159 RID: 8537
		private static readonly MessageParser<ExchangeMountsPaddockAddedEvent> _parser;

		// Token: 0x0400215A RID: 8538
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400215B RID: 8539
		public const int MountsFieldNumber = 1;

		// Token: 0x0400215C RID: 8540
		private static readonly FieldCodec<MountData> _repeated_mounts_codec;

		// Token: 0x0400215D RID: 8541
		private readonly RepeatedField<MountData> mounts_;

		// Token: 0x0400215E RID: 8542
		internal static ExchangeMountsPaddockAddedEvent PIC5eOOqmVZHHJwXdiZK;
	}
}
