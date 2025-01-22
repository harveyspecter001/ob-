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
	// Token: 0x02000D14 RID: 3348
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationInformationEvent : IMessage<AllianceApplicationInformationEvent>, IMessage, IEquatable<AllianceApplicationInformationEvent>, IDeepCloneable<AllianceApplicationInformationEvent>, IBufferMessage
	{
		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x0600A11D RID: 41245 RVA: 0x0028898C File Offset: 0x00286B8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceApplicationInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x0600A11E RID: 41246 RVA: 0x0028899C File Offset: 0x00286B9C
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

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x0600A11F RID: 41247 RVA: 0x002889AC File Offset: 0x00286BAC
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

		// Token: 0x0600A120 RID: 41248 RVA: 0x002889BC File Offset: 0x00286BBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationInformationEvent()
		{
		}

		// Token: 0x0600A121 RID: 41249 RVA: 0x002889CC File Offset: 0x00286BCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationInformationEvent(AllianceApplicationInformationEvent other)
		{
		}

		// Token: 0x0600A122 RID: 41250 RVA: 0x002889DC File Offset: 0x00286BDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x0600A123 RID: 41251 RVA: 0x002889EC File Offset: 0x00286BEC
		// (set) Token: 0x0600A124 RID: 41252 RVA: 0x002889FC File Offset: 0x00286BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllianceInformation Alliance
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

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x0600A125 RID: 41253 RVA: 0x00288A0C File Offset: 0x00286C0C
		// (set) Token: 0x0600A126 RID: 41254 RVA: 0x00288A1C File Offset: 0x00286C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialApplicationInformation ApplicationInformation
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

		// Token: 0x0600A127 RID: 41255 RVA: 0x00288A2C File Offset: 0x00286C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A128 RID: 41256 RVA: 0x00288A3C File Offset: 0x00286C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationInformationEvent other)
		{
			return true;
		}

		// Token: 0x0600A129 RID: 41257 RVA: 0x00288A4C File Offset: 0x00286C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A12A RID: 41258 RVA: 0x00288A5C File Offset: 0x00286C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A12B RID: 41259 RVA: 0x00288A6C File Offset: 0x00286C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A12C RID: 41260 RVA: 0x00288A7C File Offset: 0x00286C7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A12D RID: 41261 RVA: 0x00288A8C File Offset: 0x00286C8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A12E RID: 41262 RVA: 0x00288A9C File Offset: 0x00286C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationInformationEvent other)
		{
		}

		// Token: 0x0600A12F RID: 41263 RVA: 0x00288AAC File Offset: 0x00286CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A130 RID: 41264 RVA: 0x00288ABC File Offset: 0x00286CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A131 RID: 41265 RVA: 0x00288ACC File Offset: 0x00286CCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationInformationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						AllianceApplicationInformationEvent._parser = new MessageParser<AllianceApplicationInformationEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_49;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					}
					return;
				}
				IL_49:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 2;
			}
		}

		// Token: 0x0600A132 RID: 41266 RVA: 0x00288B9C File Offset: 0x00286D9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uYBg8dJKxZuHCXiFpKfP()
		{
			return true;
		}

		// Token: 0x0600A133 RID: 41267 RVA: 0x00288BA4 File Offset: 0x00286DA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationInformationEvent saOK5fJK4H1vn8so8w8q()
		{
			return null;
		}

		// Token: 0x04003B8B RID: 15243
		private static readonly MessageParser<AllianceApplicationInformationEvent> _parser;

		// Token: 0x04003B8C RID: 15244
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B8D RID: 15245
		public const int AllianceFieldNumber = 1;

		// Token: 0x04003B8E RID: 15246
		private AllianceInformation alliance_;

		// Token: 0x04003B8F RID: 15247
		public const int ApplicationInformationFieldNumber = 2;

		// Token: 0x04003B90 RID: 15248
		private SocialApplicationInformation applicationInformation_;

		// Token: 0x04003B91 RID: 15249
		private static AllianceApplicationInformationEvent aEtpKBJKNQrcKno1MVcK;
	}
}
