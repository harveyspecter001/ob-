using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006F2 RID: 1778
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeFocusedReadyRequest : IMessage<ExchangeFocusedReadyRequest>, IMessage, IEquatable<ExchangeFocusedReadyRequest>, IDeepCloneable<ExchangeFocusedReadyRequest>, IBufferMessage
	{
		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06005700 RID: 22272 RVA: 0x00214710 File Offset: 0x00212910
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeFocusedReadyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06005701 RID: 22273 RVA: 0x00214720 File Offset: 0x00212920
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

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06005702 RID: 22274 RVA: 0x00214730 File Offset: 0x00212930
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

		// Token: 0x06005703 RID: 22275 RVA: 0x00214740 File Offset: 0x00212940
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeFocusedReadyRequest()
		{
		}

		// Token: 0x06005704 RID: 22276 RVA: 0x00214750 File Offset: 0x00212950
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeFocusedReadyRequest(ExchangeFocusedReadyRequest other)
		{
		}

		// Token: 0x06005705 RID: 22277 RVA: 0x00214760 File Offset: 0x00212960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeFocusedReadyRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06005706 RID: 22278 RVA: 0x00214770 File Offset: 0x00212970
		// (set) Token: 0x06005707 RID: 22279 RVA: 0x00214780 File Offset: 0x00212980
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Ready
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

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06005708 RID: 22280 RVA: 0x00214790 File Offset: 0x00212990
		// (set) Token: 0x06005709 RID: 22281 RVA: 0x002147A0 File Offset: 0x002129A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Step
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

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x0600570A RID: 22282 RVA: 0x002147B0 File Offset: 0x002129B0
		// (set) Token: 0x0600570B RID: 22283 RVA: 0x002147C0 File Offset: 0x002129C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FocusActionId
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

		// Token: 0x0600570C RID: 22284 RVA: 0x002147D0 File Offset: 0x002129D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600570D RID: 22285 RVA: 0x002147E0 File Offset: 0x002129E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeFocusedReadyRequest other)
		{
			return true;
		}

		// Token: 0x0600570E RID: 22286 RVA: 0x002147F0 File Offset: 0x002129F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x00214800 File Offset: 0x00212A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x00214810 File Offset: 0x00212A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x00214820 File Offset: 0x00212A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005712 RID: 22290 RVA: 0x00214830 File Offset: 0x00212A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x00214840 File Offset: 0x00212A40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeFocusedReadyRequest other)
		{
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x00214850 File Offset: 0x00212A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005715 RID: 22293 RVA: 0x00214860 File Offset: 0x00212A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005716 RID: 22294 RVA: 0x00214870 File Offset: 0x00212A70
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeFocusedReadyRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					ExchangeFocusedReadyRequest._parser = new MessageParser<ExchangeFocusedReadyRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06005717 RID: 22295 RVA: 0x00214954 File Offset: 0x00212B54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PiY5SpOMPPyd2geEK38I()
		{
			return true;
		}

		// Token: 0x06005718 RID: 22296 RVA: 0x0021495C File Offset: 0x00212B5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeFocusedReadyRequest UKTDkeOMSiabZjTrNsvv()
		{
			return null;
		}

		// Token: 0x04001E76 RID: 7798
		private static readonly MessageParser<ExchangeFocusedReadyRequest> _parser;

		// Token: 0x04001E77 RID: 7799
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E78 RID: 7800
		public const int ReadyFieldNumber = 1;

		// Token: 0x04001E79 RID: 7801
		private bool ready_;

		// Token: 0x04001E7A RID: 7802
		public const int StepFieldNumber = 2;

		// Token: 0x04001E7B RID: 7803
		private int step_;

		// Token: 0x04001E7C RID: 7804
		public const int FocusActionIdFieldNumber = 3;

		// Token: 0x04001E7D RID: 7805
		private int focusActionId_;

		// Token: 0x04001E7E RID: 7806
		internal static ExchangeFocusedReadyRequest LocQA6OMib6X82vSD6o5;
	}
}
