using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Notification
{
	// Token: 0x02000356 RID: 854
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NotificationEvent : IMessage<NotificationEvent>, IMessage, IEquatable<NotificationEvent>, IDeepCloneable<NotificationEvent>, IBufferMessage
	{
		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x001C4ED4 File Offset: 0x001C30D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NotificationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x001C4EE4 File Offset: 0x001C30E4
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

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x001C4EF4 File Offset: 0x001C30F4
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

		// Token: 0x06002819 RID: 10265 RVA: 0x001C4F04 File Offset: 0x001C3104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NotificationEvent()
		{
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x001C4F14 File Offset: 0x001C3114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NotificationEvent(NotificationEvent other)
		{
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x001C4F24 File Offset: 0x001C3124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NotificationEvent Clone()
		{
			return null;
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600281C RID: 10268 RVA: 0x001C4F34 File Offset: 0x001C3134
		// (set) Token: 0x0600281D RID: 10269 RVA: 0x001C4F44 File Offset: 0x001C3144
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Id
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

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x0600281E RID: 10270 RVA: 0x001C4F54 File Offset: 0x001C3154
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<string> Parameters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x0600281F RID: 10271 RVA: 0x001C4F64 File Offset: 0x001C3164
		// (set) Token: 0x06002820 RID: 10272 RVA: 0x001C4F74 File Offset: 0x001C3174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Force
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

		// Token: 0x06002821 RID: 10273 RVA: 0x001C4F84 File Offset: 0x001C3184
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x001C4F94 File Offset: 0x001C3194
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NotificationEvent other)
		{
			return true;
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x001C4FA4 File Offset: 0x001C31A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x001C4FB4 File Offset: 0x001C31B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x001C4FC4 File Offset: 0x001C31C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x001C4FD4 File Offset: 0x001C31D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x001C4FE4 File Offset: 0x001C31E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x001C4FF4 File Offset: 0x001C31F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NotificationEvent other)
		{
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x001C5004 File Offset: 0x001C3204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x001C5014 File Offset: 0x001C3214
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x001C5024 File Offset: 0x001C3224
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NotificationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					NotificationEvent._repeated_parameters_codec = UhvKwdMSigIudSGM6ge.XVInXhlssT(18U, UhvKwdMSigIudSGM6ge.BvYMM58cmD);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				NotificationEvent._parser = new MessageParser<NotificationEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x001C5124 File Offset: 0x001C3324
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool txl0wXOhoj6N1y5G8YuU()
		{
			return true;
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x001C512C File Offset: 0x001C332C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NotificationEvent atWGPYOh1mVoegnTowvu()
		{
			return null;
		}

		// Token: 0x04000E42 RID: 3650
		private static readonly MessageParser<NotificationEvent> _parser;

		// Token: 0x04000E43 RID: 3651
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E44 RID: 3652
		public const int IdFieldNumber = 1;

		// Token: 0x04000E45 RID: 3653
		private int id_;

		// Token: 0x04000E46 RID: 3654
		public const int ParametersFieldNumber = 2;

		// Token: 0x04000E47 RID: 3655
		private static readonly FieldCodec<string> _repeated_parameters_codec;

		// Token: 0x04000E48 RID: 3656
		private readonly RepeatedField<string> parameters_;

		// Token: 0x04000E49 RID: 3657
		public const int ForceFieldNumber = 3;

		// Token: 0x04000E4A RID: 3658
		private bool force_;

		// Token: 0x04000E4B RID: 3659
		private static NotificationEvent N4UiWSOhvnoUeEKwW3Pa;
	}
}
