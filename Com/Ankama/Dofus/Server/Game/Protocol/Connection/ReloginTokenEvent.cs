using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection
{
	// Token: 0x020008A3 RID: 2211
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReloginTokenEvent : IMessage<ReloginTokenEvent>, IMessage, IEquatable<ReloginTokenEvent>, IDeepCloneable<ReloginTokenEvent>, IBufferMessage
	{
		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06006B66 RID: 27494 RVA: 0x00230FE0 File Offset: 0x0022F1E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ReloginTokenEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06006B67 RID: 27495 RVA: 0x00230FF0 File Offset: 0x0022F1F0
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

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06006B68 RID: 27496 RVA: 0x00231000 File Offset: 0x0022F200
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

		// Token: 0x06006B69 RID: 27497 RVA: 0x00231010 File Offset: 0x0022F210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReloginTokenEvent()
		{
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x00231020 File Offset: 0x0022F220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReloginTokenEvent(ReloginTokenEvent other)
		{
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x00231030 File Offset: 0x0022F230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReloginTokenEvent Clone()
		{
			return null;
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06006B6C RID: 27500 RVA: 0x00231040 File Offset: 0x0022F240
		// (set) Token: 0x06006B6D RID: 27501 RVA: 0x00231050 File Offset: 0x0022F250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ValidToken
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

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06006B6E RID: 27502 RVA: 0x00231060 File Offset: 0x0022F260
		// (set) Token: 0x06006B6F RID: 27503 RVA: 0x00231070 File Offset: 0x0022F270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Token
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

		// Token: 0x06006B70 RID: 27504 RVA: 0x00231080 File Offset: 0x0022F280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x00231090 File Offset: 0x0022F290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ReloginTokenEvent other)
		{
			return true;
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x002310A0 File Offset: 0x0022F2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x002310B0 File Offset: 0x0022F2B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x002310C0 File Offset: 0x0022F2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x002310D0 File Offset: 0x0022F2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006B76 RID: 27510 RVA: 0x002310E0 File Offset: 0x0022F2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006B77 RID: 27511 RVA: 0x002310F0 File Offset: 0x0022F2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ReloginTokenEvent other)
		{
		}

		// Token: 0x06006B78 RID: 27512 RVA: 0x00231100 File Offset: 0x0022F300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x00231110 File Offset: 0x0022F310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x00231120 File Offset: 0x0022F320
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ReloginTokenEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					return;
				case 4:
					ReloginTokenEvent._parser = new MessageParser<ReloginTokenEvent>(() => null);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x00231204 File Offset: 0x0022F404
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xL7S60Jm5mKtPfKind4M()
		{
			return true;
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x0023120C File Offset: 0x0022F40C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ReloginTokenEvent hXdryAJmyvva0A2Fy7ch()
		{
			return null;
		}

		// Token: 0x04002589 RID: 9609
		private static readonly MessageParser<ReloginTokenEvent> _parser;

		// Token: 0x0400258A RID: 9610
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400258B RID: 9611
		public const int ValidTokenFieldNumber = 1;

		// Token: 0x0400258C RID: 9612
		private bool validToken_;

		// Token: 0x0400258D RID: 9613
		public const int TokenFieldNumber = 2;

		// Token: 0x0400258E RID: 9614
		private string token_;

		// Token: 0x0400258F RID: 9615
		internal static ReloginTokenEvent SlQ03yJmaB7fFmvabOdv;
	}
}
