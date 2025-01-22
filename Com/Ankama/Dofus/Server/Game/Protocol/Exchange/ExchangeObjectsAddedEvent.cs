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
	// Token: 0x02000717 RID: 1815
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectsAddedEvent : IMessage<ExchangeObjectsAddedEvent>, IMessage, IEquatable<ExchangeObjectsAddedEvent>, IDeepCloneable<ExchangeObjectsAddedEvent>, IBufferMessage
	{
		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x060058CD RID: 22733 RVA: 0x00216950 File Offset: 0x00214B50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeObjectsAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x060058CE RID: 22734 RVA: 0x00216960 File Offset: 0x00214B60
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

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x060058CF RID: 22735 RVA: 0x00216970 File Offset: 0x00214B70
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

		// Token: 0x060058D0 RID: 22736 RVA: 0x00216980 File Offset: 0x00214B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectsAddedEvent()
		{
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x00216990 File Offset: 0x00214B90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectsAddedEvent(ExchangeObjectsAddedEvent other)
		{
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x002169A0 File Offset: 0x00214BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectsAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x060058D3 RID: 22739 RVA: 0x002169B0 File Offset: 0x00214BB0
		// (set) Token: 0x060058D4 RID: 22740 RVA: 0x002169C0 File Offset: 0x00214BC0
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

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x060058D5 RID: 22741 RVA: 0x002169D0 File Offset: 0x00214BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectItemInventory> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x060058D6 RID: 22742 RVA: 0x002169E0 File Offset: 0x00214BE0
		// (set) Token: 0x060058D7 RID: 22743 RVA: 0x002169F0 File Offset: 0x00214BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float FmPower
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (float)0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x060058D8 RID: 22744 RVA: 0x00216A00 File Offset: 0x00214C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFmPower
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x00216A10 File Offset: 0x00214C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearFmPower()
		{
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x00216A20 File Offset: 0x00214C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x00216A30 File Offset: 0x00214C30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectsAddedEvent other)
		{
			return true;
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x00216A40 File Offset: 0x00214C40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x00216A50 File Offset: 0x00214C50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x00216A60 File Offset: 0x00214C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060058DF RID: 22751 RVA: 0x00216A70 File Offset: 0x00214C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x00216A80 File Offset: 0x00214C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060058E1 RID: 22753 RVA: 0x00216A90 File Offset: 0x00214C90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectsAddedEvent other)
		{
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x00216AA0 File Offset: 0x00214CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x00216AB0 File Offset: 0x00214CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x00216AC0 File Offset: 0x00214CC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectsAddedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					ExchangeObjectsAddedEvent.FmPowerDefaultValue = 0f;
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					ExchangeObjectsAddedEvent._repeated_objects_codec = FieldCodec.ForMessage<ObjectItemInventory>(18U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 6;
					break;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
					{
						num2 = 2;
					}
					break;
				case 6:
					ExchangeObjectsAddedEvent._parser = new MessageParser<ExchangeObjectsAddedEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x00216BF4 File Offset: 0x00214DF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KeWUUuOuVN1uQNtcX0IQ()
		{
			return true;
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x00216BFC File Offset: 0x00214DFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectsAddedEvent ytMnn0Ou0CbFto1MxqgB()
		{
			return null;
		}

		// Token: 0x04001F18 RID: 7960
		private static readonly MessageParser<ExchangeObjectsAddedEvent> _parser;

		// Token: 0x04001F19 RID: 7961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F1A RID: 7962
		private int _hasBits0;

		// Token: 0x04001F1B RID: 7963
		public const int RemoteFieldNumber = 1;

		// Token: 0x04001F1C RID: 7964
		private bool remote_;

		// Token: 0x04001F1D RID: 7965
		public const int ObjectsFieldNumber = 2;

		// Token: 0x04001F1E RID: 7966
		private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

		// Token: 0x04001F1F RID: 7967
		private readonly RepeatedField<ObjectItemInventory> objects_;

		// Token: 0x04001F20 RID: 7968
		public const int FmPowerFieldNumber = 3;

		// Token: 0x04001F21 RID: 7969
		private static readonly float FmPowerDefaultValue;

		// Token: 0x04001F22 RID: 7970
		private float fmPower_;

		// Token: 0x04001F23 RID: 7971
		internal static ExchangeObjectsAddedEvent SwyYm5Ourei1Ja9xk1CZ;
	}
}
