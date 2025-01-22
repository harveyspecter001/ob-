using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D00 RID: 3328
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRecruitmentInvalidateEvent : IMessage<AllianceRecruitmentInvalidateEvent>, IMessage, IEquatable<AllianceRecruitmentInvalidateEvent>, IDeepCloneable<AllianceRecruitmentInvalidateEvent>, IBufferMessage
	{
		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x0600A019 RID: 40985 RVA: 0x002874DC File Offset: 0x002856DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceRecruitmentInvalidateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x0600A01A RID: 40986 RVA: 0x002874EC File Offset: 0x002856EC
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

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x0600A01B RID: 40987 RVA: 0x002874FC File Offset: 0x002856FC
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

		// Token: 0x0600A01C RID: 40988 RVA: 0x0028750C File Offset: 0x0028570C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentInvalidateEvent()
		{
		}

		// Token: 0x0600A01D RID: 40989 RVA: 0x0028751C File Offset: 0x0028571C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentInvalidateEvent(AllianceRecruitmentInvalidateEvent other)
		{
		}

		// Token: 0x0600A01E RID: 40990 RVA: 0x0028752C File Offset: 0x0028572C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentInvalidateEvent Clone()
		{
			return null;
		}

		// Token: 0x0600A01F RID: 40991 RVA: 0x0028753C File Offset: 0x0028573C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A020 RID: 40992 RVA: 0x0028754C File Offset: 0x0028574C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRecruitmentInvalidateEvent other)
		{
			return true;
		}

		// Token: 0x0600A021 RID: 40993 RVA: 0x0028755C File Offset: 0x0028575C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A022 RID: 40994 RVA: 0x0028756C File Offset: 0x0028576C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A023 RID: 40995 RVA: 0x0028757C File Offset: 0x0028577C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A024 RID: 40996 RVA: 0x0028758C File Offset: 0x0028578C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A025 RID: 40997 RVA: 0x0028759C File Offset: 0x0028579C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A026 RID: 40998 RVA: 0x002875AC File Offset: 0x002857AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRecruitmentInvalidateEvent other)
		{
		}

		// Token: 0x0600A027 RID: 40999 RVA: 0x002875BC File Offset: 0x002857BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A028 RID: 41000 RVA: 0x002875CC File Offset: 0x002857CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A029 RID: 41001 RVA: 0x002875DC File Offset: 0x002857DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRecruitmentInvalidateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AllianceRecruitmentInvalidateEvent._parser = new MessageParser<AllianceRecruitmentInvalidateEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600A02A RID: 41002 RVA: 0x002876C0 File Offset: 0x002858C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mFelmuJjbAdQTrXcb3QB()
		{
			return true;
		}

		// Token: 0x0600A02B RID: 41003 RVA: 0x002876C8 File Offset: 0x002858C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRecruitmentInvalidateEvent yLKFo8JjiwKoPwID5Leb()
		{
			return null;
		}

		// Token: 0x04003B45 RID: 15173
		private static readonly MessageParser<AllianceRecruitmentInvalidateEvent> _parser;

		// Token: 0x04003B46 RID: 15174
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B47 RID: 15175
		private static AllianceRecruitmentInvalidateEvent KCwSZmJjYfKq9M3muf6G;
	}
}
