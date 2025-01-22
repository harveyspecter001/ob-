using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D16 RID: 3350
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationNoInformationEvent : IMessage<AllianceApplicationNoInformationEvent>, IMessage, IEquatable<AllianceApplicationNoInformationEvent>, IDeepCloneable<AllianceApplicationNoInformationEvent>, IBufferMessage
	{
		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x0600A139 RID: 41273 RVA: 0x00288BAC File Offset: 0x00286DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceApplicationNoInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x0600A13A RID: 41274 RVA: 0x00288BBC File Offset: 0x00286DBC
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

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x0600A13B RID: 41275 RVA: 0x00288BCC File Offset: 0x00286DCC
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

		// Token: 0x0600A13C RID: 41276 RVA: 0x00288BDC File Offset: 0x00286DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationNoInformationEvent()
		{
		}

		// Token: 0x0600A13D RID: 41277 RVA: 0x00288BEC File Offset: 0x00286DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationNoInformationEvent(AllianceApplicationNoInformationEvent other)
		{
		}

		// Token: 0x0600A13E RID: 41278 RVA: 0x00288BFC File Offset: 0x00286DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationNoInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x0600A13F RID: 41279 RVA: 0x00288C0C File Offset: 0x00286E0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A140 RID: 41280 RVA: 0x00288C1C File Offset: 0x00286E1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationNoInformationEvent other)
		{
			return true;
		}

		// Token: 0x0600A141 RID: 41281 RVA: 0x00288C2C File Offset: 0x00286E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A142 RID: 41282 RVA: 0x00288C3C File Offset: 0x00286E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A143 RID: 41283 RVA: 0x00288C4C File Offset: 0x00286E4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A144 RID: 41284 RVA: 0x00288C5C File Offset: 0x00286E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A145 RID: 41285 RVA: 0x00288C6C File Offset: 0x00286E6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A146 RID: 41286 RVA: 0x00288C7C File Offset: 0x00286E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationNoInformationEvent other)
		{
		}

		// Token: 0x0600A147 RID: 41287 RVA: 0x00288C8C File Offset: 0x00286E8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A148 RID: 41288 RVA: 0x00288C9C File Offset: 0x00286E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A149 RID: 41289 RVA: 0x00288CAC File Offset: 0x00286EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationNoInformationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AllianceApplicationNoInformationEvent._parser = new MessageParser<AllianceApplicationNoInformationEvent>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600A14A RID: 41290 RVA: 0x00288D78 File Offset: 0x00286F78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xVSy9VJKKpjUs0uc2TrA()
		{
			return true;
		}

		// Token: 0x0600A14B RID: 41291 RVA: 0x00288D80 File Offset: 0x00286F80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationNoInformationEvent QW9EyBJKIJkhSF15kibF()
		{
			return null;
		}

		// Token: 0x04003B94 RID: 15252
		private static readonly MessageParser<AllianceApplicationNoInformationEvent> _parser;

		// Token: 0x04003B95 RID: 15253
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B96 RID: 15254
		private static AllianceApplicationNoInformationEvent BDV13SJKjcriBbe3WDdu;
	}
}
