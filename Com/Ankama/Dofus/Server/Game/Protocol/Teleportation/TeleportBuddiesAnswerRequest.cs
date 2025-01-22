using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x02000083 RID: 131
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportBuddiesAnswerRequest : IMessage<TeleportBuddiesAnswerRequest>, IMessage, IEquatable<TeleportBuddiesAnswerRequest>, IDeepCloneable<TeleportBuddiesAnswerRequest>, IBufferMessage
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0018B5CC File Offset: 0x001897CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TeleportBuddiesAnswerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x0018B5DC File Offset: 0x001897DC
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0018B5EC File Offset: 0x001897EC
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

		// Token: 0x06000544 RID: 1348 RVA: 0x0018B5FC File Offset: 0x001897FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportBuddiesAnswerRequest()
		{
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0018B60C File Offset: 0x0018980C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportBuddiesAnswerRequest(TeleportBuddiesAnswerRequest other)
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0018B61C File Offset: 0x0018981C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportBuddiesAnswerRequest Clone()
		{
			return null;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0018B62C File Offset: 0x0018982C
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x0018B63C File Offset: 0x0018983C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x06000549 RID: 1353 RVA: 0x0018B64C File Offset: 0x0018984C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0018B65C File Offset: 0x0018985C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TeleportBuddiesAnswerRequest other)
		{
			return true;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0018B66C File Offset: 0x0018986C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0018B67C File Offset: 0x0018987C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0018B68C File Offset: 0x0018988C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0018B69C File Offset: 0x0018989C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0018B6AC File Offset: 0x001898AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0018B6BC File Offset: 0x001898BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TeleportBuddiesAnswerRequest other)
		{
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0018B6CC File Offset: 0x001898CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0018B6DC File Offset: 0x001898DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0018B6EC File Offset: 0x001898EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TeleportBuddiesAnswerRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					TeleportBuddiesAnswerRequest._parser = new MessageParser<TeleportBuddiesAnswerRequest>(() => null);
					num2 = 2;
					break;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0018B7B8 File Offset: 0x001899B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p8NZFlOKTidTNm6v7lmc()
		{
			return true;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0018B7C0 File Offset: 0x001899C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TeleportBuddiesAnswerRequest Bbt36IOKpwlJhQ8KYYSh()
		{
			return null;
		}

		// Token: 0x04000207 RID: 519
		private static readonly MessageParser<TeleportBuddiesAnswerRequest> _parser;

		// Token: 0x04000208 RID: 520
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000209 RID: 521
		public const int AcceptFieldNumber = 1;

		// Token: 0x0400020A RID: 522
		private bool accept_;

		// Token: 0x0400020B RID: 523
		private static TeleportBuddiesAnswerRequest rau92KOK7RSrnld9HtHf;
	}
}
