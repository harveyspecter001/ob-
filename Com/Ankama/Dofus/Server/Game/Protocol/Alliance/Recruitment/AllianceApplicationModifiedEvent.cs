using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D1C RID: 3356
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationModifiedEvent : IMessage<AllianceApplicationModifiedEvent>, IMessage, IEquatable<AllianceApplicationModifiedEvent>, IDeepCloneable<AllianceApplicationModifiedEvent>, IBufferMessage
	{
		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x0600A18C RID: 41356 RVA: 0x00289258 File Offset: 0x00287458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceApplicationModifiedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x0600A18D RID: 41357 RVA: 0x00289268 File Offset: 0x00287468
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

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x0600A18E RID: 41358 RVA: 0x00289278 File Offset: 0x00287478
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

		// Token: 0x0600A18F RID: 41359 RVA: 0x00289288 File Offset: 0x00287488
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationModifiedEvent()
		{
		}

		// Token: 0x0600A190 RID: 41360 RVA: 0x00289298 File Offset: 0x00287498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationModifiedEvent(AllianceApplicationModifiedEvent other)
		{
		}

		// Token: 0x0600A191 RID: 41361 RVA: 0x002892A8 File Offset: 0x002874A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationModifiedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x0600A192 RID: 41362 RVA: 0x002892B8 File Offset: 0x002874B8
		// (set) Token: 0x0600A193 RID: 41363 RVA: 0x002892C8 File Offset: 0x002874C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SocialApplicationInformation Apply
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

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x0600A194 RID: 41364 RVA: 0x002892D8 File Offset: 0x002874D8
		// (set) Token: 0x0600A195 RID: 41365 RVA: 0x002892EC File Offset: 0x002874EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SocialApplicationState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SocialApplicationState)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x0600A196 RID: 41366 RVA: 0x002892FC File Offset: 0x002874FC
		// (set) Token: 0x0600A197 RID: 41367 RVA: 0x0028930C File Offset: 0x0028750C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x0028931C File Offset: 0x0028751C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x0028932C File Offset: 0x0028752C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationModifiedEvent other)
		{
			return true;
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x0028933C File Offset: 0x0028753C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x0028934C File Offset: 0x0028754C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A19C RID: 41372 RVA: 0x0028935C File Offset: 0x0028755C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A19D RID: 41373 RVA: 0x0028936C File Offset: 0x0028756C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A19E RID: 41374 RVA: 0x0028937C File Offset: 0x0028757C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A19F RID: 41375 RVA: 0x0028938C File Offset: 0x0028758C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationModifiedEvent other)
		{
		}

		// Token: 0x0600A1A0 RID: 41376 RVA: 0x0028939C File Offset: 0x0028759C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x002893AC File Offset: 0x002875AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x002893BC File Offset: 0x002875BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationModifiedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AllianceApplicationModifiedEvent._parser = new MessageParser<AllianceApplicationModifiedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x002894A0 File Offset: 0x002876A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k3JGJpJKa973je3CtAFl()
		{
			return true;
		}

		// Token: 0x0600A1A4 RID: 41380 RVA: 0x002894A8 File Offset: 0x002876A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationModifiedEvent c1cpf3JK56OeXFs7spb5()
		{
			return null;
		}

		// Token: 0x04003BB0 RID: 15280
		private static readonly MessageParser<AllianceApplicationModifiedEvent> _parser;

		// Token: 0x04003BB1 RID: 15281
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BB2 RID: 15282
		public const int ApplyFieldNumber = 1;

		// Token: 0x04003BB3 RID: 15283
		private SocialApplicationInformation apply_;

		// Token: 0x04003BB4 RID: 15284
		public const int StateFieldNumber = 2;

		// Token: 0x04003BB5 RID: 15285
		private SocialApplicationState state_;

		// Token: 0x04003BB6 RID: 15286
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04003BB7 RID: 15287
		private long playerId_;

		// Token: 0x04003BB8 RID: 15288
		internal static AllianceApplicationModifiedEvent ii1OIDJK165N5FPukvDB;
	}
}
