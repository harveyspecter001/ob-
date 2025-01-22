using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x02000300 RID: 768
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyNameSetErrorEvent : IMessage<PartyNameSetErrorEvent>, IMessage, IEquatable<PartyNameSetErrorEvent>, IDeepCloneable<PartyNameSetErrorEvent>, IBufferMessage
	{
		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x001BE754 File Offset: 0x001BC954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyNameSetErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x001BE764 File Offset: 0x001BC964
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

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x001BE774 File Offset: 0x001BC974
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

		// Token: 0x0600240C RID: 9228 RVA: 0x001BE784 File Offset: 0x001BC984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNameSetErrorEvent()
		{
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x001BE794 File Offset: 0x001BC994
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNameSetErrorEvent(PartyNameSetErrorEvent other)
		{
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x001BE7A4 File Offset: 0x001BC9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNameSetErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x001BE7B4 File Offset: 0x001BC9B4
		// (set) Token: 0x06002410 RID: 9232 RVA: 0x001BE7C4 File Offset: 0x001BC9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartyId
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

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x001BE7D4 File Offset: 0x001BC9D4
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x001BE7E8 File Offset: 0x001BC9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartyNameSetErrorEvent.Types.PartyNameError Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PartyNameSetErrorEvent.Types.PartyNameError)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x001BE7F8 File Offset: 0x001BC9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x001BE808 File Offset: 0x001BCA08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyNameSetErrorEvent other)
		{
			return true;
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x001BE818 File Offset: 0x001BCA18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x001BE828 File Offset: 0x001BCA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x001BE838 File Offset: 0x001BCA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x001BE848 File Offset: 0x001BCA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x001BE858 File Offset: 0x001BCA58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x001BE868 File Offset: 0x001BCA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyNameSetErrorEvent other)
		{
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x001BE878 File Offset: 0x001BCA78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x001BE888 File Offset: 0x001BCA88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x001BE898 File Offset: 0x001BCA98
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyNameSetErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					PartyNameSetErrorEvent._parser = new MessageParser<PartyNameSetErrorEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x001BE97C File Offset: 0x001BCB7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SjWCVAOLb6FMgTQndek9()
		{
			return true;
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x001BE984 File Offset: 0x001BCB84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyNameSetErrorEvent WTVadgOLiiIo5oZIFfDr()
		{
			return null;
		}

		// Token: 0x04000CC6 RID: 3270
		private static readonly MessageParser<PartyNameSetErrorEvent> _parser;

		// Token: 0x04000CC7 RID: 3271
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CC8 RID: 3272
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000CC9 RID: 3273
		private int partyId_;

		// Token: 0x04000CCA RID: 3274
		public const int ResultFieldNumber = 2;

		// Token: 0x04000CCB RID: 3275
		private PartyNameSetErrorEvent.Types.PartyNameError result_;

		// Token: 0x04000CCC RID: 3276
		private static PartyNameSetErrorEvent csTREwOLYmWtbGBm6DEQ;

		// Token: 0x02000301 RID: 769
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06002420 RID: 9248 RVA: 0x002B6790 File Offset: 0x002B4990
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000302 RID: 770
			public enum PartyNameError
			{
				// Token: 0x04000CCE RID: 3278
				[OriginalName("UNDEFINED_ERROR")]
				UndefinedError,
				// Token: 0x04000CCF RID: 3279
				[OriginalName("INVALID")]
				Invalid,
				// Token: 0x04000CD0 RID: 3280
				[OriginalName("ALREADY_USED")]
				AlreadyUsed,
				// Token: 0x04000CD1 RID: 3281
				[OriginalName("UNALLOWED_RIGHTS")]
				UnallowedRights,
				// Token: 0x04000CD2 RID: 3282
				[OriginalName("UNALLOWED_NOW")]
				UnallowedNow
			}
		}
	}
}
