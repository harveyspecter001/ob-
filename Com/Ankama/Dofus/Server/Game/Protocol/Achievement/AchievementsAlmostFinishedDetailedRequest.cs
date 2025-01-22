using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement
{
	// Token: 0x02000DBF RID: 3519
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievementsAlmostFinishedDetailedRequest : IMessage<AchievementsAlmostFinishedDetailedRequest>, IMessage, IEquatable<AchievementsAlmostFinishedDetailedRequest>, IDeepCloneable<AchievementsAlmostFinishedDetailedRequest>, IBufferMessage
	{
		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x0600A985 RID: 43397 RVA: 0x00297BD8 File Offset: 0x00295DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementsAlmostFinishedDetailedRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x0600A986 RID: 43398 RVA: 0x00297BE8 File Offset: 0x00295DE8
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

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x0600A987 RID: 43399 RVA: 0x00297BF8 File Offset: 0x00295DF8
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

		// Token: 0x0600A988 RID: 43400 RVA: 0x00297C08 File Offset: 0x00295E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsAlmostFinishedDetailedRequest()
		{
		}

		// Token: 0x0600A989 RID: 43401 RVA: 0x00297C18 File Offset: 0x00295E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsAlmostFinishedDetailedRequest(AchievementsAlmostFinishedDetailedRequest other)
		{
		}

		// Token: 0x0600A98A RID: 43402 RVA: 0x00297C28 File Offset: 0x00295E28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsAlmostFinishedDetailedRequest Clone()
		{
			return null;
		}

		// Token: 0x0600A98B RID: 43403 RVA: 0x00297C38 File Offset: 0x00295E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A98C RID: 43404 RVA: 0x00297C48 File Offset: 0x00295E48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievementsAlmostFinishedDetailedRequest other)
		{
			return true;
		}

		// Token: 0x0600A98D RID: 43405 RVA: 0x00297C58 File Offset: 0x00295E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A98E RID: 43406 RVA: 0x00297C68 File Offset: 0x00295E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A98F RID: 43407 RVA: 0x00297C78 File Offset: 0x00295E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A990 RID: 43408 RVA: 0x00297C88 File Offset: 0x00295E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A991 RID: 43409 RVA: 0x00297C98 File Offset: 0x00295E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A992 RID: 43410 RVA: 0x00297CA8 File Offset: 0x00295EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievementsAlmostFinishedDetailedRequest other)
		{
		}

		// Token: 0x0600A993 RID: 43411 RVA: 0x00297CB8 File Offset: 0x00295EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A994 RID: 43412 RVA: 0x00297CC8 File Offset: 0x00295EC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A995 RID: 43413 RVA: 0x00297CD8 File Offset: 0x00295ED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievementsAlmostFinishedDetailedRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AchievementsAlmostFinishedDetailedRequest._parser = new MessageParser<AchievementsAlmostFinishedDetailedRequest>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600A996 RID: 43414 RVA: 0x00297DBC File Offset: 0x00295FBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zbe6ToJc9L0CtkkiMowv()
		{
			return true;
		}

		// Token: 0x0600A997 RID: 43415 RVA: 0x00297DC4 File Offset: 0x00295FC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievementsAlmostFinishedDetailedRequest onnSyTJc2B58J5ayLZSH()
		{
			return null;
		}

		// Token: 0x04003E4D RID: 15949
		private static readonly MessageParser<AchievementsAlmostFinishedDetailedRequest> _parser;

		// Token: 0x04003E4E RID: 15950
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E4F RID: 15951
		private static AchievementsAlmostFinishedDetailedRequest GHvncsJcdV83vJIl5oOq;
	}
}
