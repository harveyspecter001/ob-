using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement
{
	// Token: 0x02000DBB RID: 3515
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievementDetailsRequest : IMessage<AchievementDetailsRequest>, IMessage, IEquatable<AchievementDetailsRequest>, IDeepCloneable<AchievementDetailsRequest>, IBufferMessage
	{
		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x0600A951 RID: 43345 RVA: 0x002977B4 File Offset: 0x002959B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementDetailsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x0600A952 RID: 43346 RVA: 0x002977C4 File Offset: 0x002959C4
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

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x0600A953 RID: 43347 RVA: 0x002977D4 File Offset: 0x002959D4
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

		// Token: 0x0600A954 RID: 43348 RVA: 0x002977E4 File Offset: 0x002959E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementDetailsRequest()
		{
		}

		// Token: 0x0600A955 RID: 43349 RVA: 0x002977F4 File Offset: 0x002959F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementDetailsRequest(AchievementDetailsRequest other)
		{
		}

		// Token: 0x0600A956 RID: 43350 RVA: 0x00297804 File Offset: 0x00295A04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementDetailsRequest Clone()
		{
			return null;
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x0600A957 RID: 43351 RVA: 0x00297814 File Offset: 0x00295A14
		// (set) Token: 0x0600A958 RID: 43352 RVA: 0x00297824 File Offset: 0x00295A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AchievementId
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

		// Token: 0x0600A959 RID: 43353 RVA: 0x00297834 File Offset: 0x00295A34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A95A RID: 43354 RVA: 0x00297844 File Offset: 0x00295A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievementDetailsRequest other)
		{
			return true;
		}

		// Token: 0x0600A95B RID: 43355 RVA: 0x00297854 File Offset: 0x00295A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A95C RID: 43356 RVA: 0x00297864 File Offset: 0x00295A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A95D RID: 43357 RVA: 0x00297874 File Offset: 0x00295A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A95E RID: 43358 RVA: 0x00297884 File Offset: 0x00295A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A95F RID: 43359 RVA: 0x00297894 File Offset: 0x00295A94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A960 RID: 43360 RVA: 0x002978A4 File Offset: 0x00295AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievementDetailsRequest other)
		{
		}

		// Token: 0x0600A961 RID: 43361 RVA: 0x002978B4 File Offset: 0x00295AB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A962 RID: 43362 RVA: 0x002978C4 File Offset: 0x00295AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A963 RID: 43363 RVA: 0x002978D4 File Offset: 0x00295AD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievementDetailsRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AchievementDetailsRequest._parser = new MessageParser<AchievementDetailsRequest>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600A964 RID: 43364 RVA: 0x002979A0 File Offset: 0x00295BA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lqGlPZJcOjAJLBUb423x()
		{
			return true;
		}

		// Token: 0x0600A965 RID: 43365 RVA: 0x002979A8 File Offset: 0x00295BA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievementDetailsRequest DQj1rHJcJUxM59i4hgQ9()
		{
			return null;
		}

		// Token: 0x04003E3F RID: 15935
		private static readonly MessageParser<AchievementDetailsRequest> _parser;

		// Token: 0x04003E40 RID: 15936
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E41 RID: 15937
		public const int AchievementIdFieldNumber = 1;

		// Token: 0x04003E42 RID: 15938
		private int achievementId_;

		// Token: 0x04003E43 RID: 15939
		private static AchievementDetailsRequest W36lgCJcRT7gGgGi8nAX;
	}
}
