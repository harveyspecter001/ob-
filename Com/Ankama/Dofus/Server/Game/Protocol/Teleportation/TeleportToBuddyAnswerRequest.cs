using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x02000085 RID: 133
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportToBuddyAnswerRequest : IMessage<TeleportToBuddyAnswerRequest>, IMessage, IEquatable<TeleportToBuddyAnswerRequest>, IDeepCloneable<TeleportToBuddyAnswerRequest>, IBufferMessage
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x0018B7C8 File Offset: 0x001899C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TeleportToBuddyAnswerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0018B7D8 File Offset: 0x001899D8
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

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0018B7E8 File Offset: 0x001899E8
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

		// Token: 0x0600055E RID: 1374 RVA: 0x0018B7F8 File Offset: 0x001899F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportToBuddyAnswerRequest()
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0018B808 File Offset: 0x00189A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportToBuddyAnswerRequest(TeleportToBuddyAnswerRequest other)
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0018B818 File Offset: 0x00189A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportToBuddyAnswerRequest Clone()
		{
			return null;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x0018B828 File Offset: 0x00189A28
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x0018B838 File Offset: 0x00189A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Accept
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

		// Token: 0x06000563 RID: 1379 RVA: 0x0018B848 File Offset: 0x00189A48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0018B858 File Offset: 0x00189A58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TeleportToBuddyAnswerRequest other)
		{
			return true;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0018B868 File Offset: 0x00189A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0018B878 File Offset: 0x00189A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0018B888 File Offset: 0x00189A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0018B898 File Offset: 0x00189A98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0018B8A8 File Offset: 0x00189AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0018B8B8 File Offset: 0x00189AB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TeleportToBuddyAnswerRequest other)
		{
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0018B8C8 File Offset: 0x00189AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0018B8D8 File Offset: 0x00189AD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0018B8E8 File Offset: 0x00189AE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TeleportToBuddyAnswerRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					TeleportToBuddyAnswerRequest._parser = new MessageParser<TeleportToBuddyAnswerRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
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
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0018B9CC File Offset: 0x00189BCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FJbWHdOKY5eFjilEhA7C()
		{
			return true;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0018B9D4 File Offset: 0x00189BD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TeleportToBuddyAnswerRequest Xe53U0OKb95NJRGxsH5Z()
		{
			return null;
		}

		// Token: 0x0400020E RID: 526
		private static readonly MessageParser<TeleportToBuddyAnswerRequest> _parser;

		// Token: 0x0400020F RID: 527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000210 RID: 528
		public const int AcceptFieldNumber = 1;

		// Token: 0x04000211 RID: 529
		private bool accept_;

		// Token: 0x04000212 RID: 530
		internal static TeleportToBuddyAnswerRequest AP3mIpOKH8hqea1DUTDZ;
	}
}
