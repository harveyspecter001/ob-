using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x0200019D RID: 413
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestStepInformationRequest : IMessage<QuestStepInformationRequest>, IMessage, IEquatable<QuestStepInformationRequest>, IDeepCloneable<QuestStepInformationRequest>, IBufferMessage
	{
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x001A418C File Offset: 0x001A238C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<QuestStepInformationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x001A419C File Offset: 0x001A239C
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

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x001A41AC File Offset: 0x001A23AC
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

		// Token: 0x0600132B RID: 4907 RVA: 0x001A41BC File Offset: 0x001A23BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStepInformationRequest()
		{
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x001A41CC File Offset: 0x001A23CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStepInformationRequest(QuestStepInformationRequest other)
		{
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x001A41DC File Offset: 0x001A23DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStepInformationRequest Clone()
		{
			return null;
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x001A41EC File Offset: 0x001A23EC
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x001A41FC File Offset: 0x001A23FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
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

		// Token: 0x06001330 RID: 4912 RVA: 0x001A420C File Offset: 0x001A240C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x001A421C File Offset: 0x001A241C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestStepInformationRequest other)
		{
			return true;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x001A422C File Offset: 0x001A242C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x001A423C File Offset: 0x001A243C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x001A424C File Offset: 0x001A244C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x001A425C File Offset: 0x001A245C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x001A426C File Offset: 0x001A246C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x001A427C File Offset: 0x001A247C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestStepInformationRequest other)
		{
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x001A428C File Offset: 0x001A248C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x001A429C File Offset: 0x001A249C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x001A42AC File Offset: 0x001A24AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestStepInformationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				QuestStepInformationRequest._parser = new MessageParser<QuestStepInformationRequest>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x001A4378 File Offset: 0x001A2578
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BHeCjlOoNPiZVkSwOJ3r()
		{
			return true;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x001A4380 File Offset: 0x001A2580
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestStepInformationRequest EoOr20OoxCbJMYk4eNuX()
		{
			return null;
		}

		// Token: 0x040006E6 RID: 1766
		private static readonly MessageParser<QuestStepInformationRequest> _parser;

		// Token: 0x040006E7 RID: 1767
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006E8 RID: 1768
		public const int QuestIdFieldNumber = 1;

		// Token: 0x040006E9 RID: 1769
		private int questId_;

		// Token: 0x040006EA RID: 1770
		internal static QuestStepInformationRequest FAXitHOoX0qtUuxcgbIM;
	}
}
