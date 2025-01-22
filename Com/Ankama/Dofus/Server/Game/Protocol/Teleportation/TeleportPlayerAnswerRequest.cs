using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x02000087 RID: 135
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportPlayerAnswerRequest : IMessage<TeleportPlayerAnswerRequest>, IMessage, IEquatable<TeleportPlayerAnswerRequest>, IDeepCloneable<TeleportPlayerAnswerRequest>, IBufferMessage
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0018B9DC File Offset: 0x00189BDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TeleportPlayerAnswerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0018B9EC File Offset: 0x00189BEC
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0018B9FC File Offset: 0x00189BFC
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

		// Token: 0x06000578 RID: 1400 RVA: 0x0018BA0C File Offset: 0x00189C0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportPlayerAnswerRequest()
		{
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0018BA1C File Offset: 0x00189C1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportPlayerAnswerRequest(TeleportPlayerAnswerRequest other)
		{
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0018BA2C File Offset: 0x00189C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportPlayerAnswerRequest Clone()
		{
			return null;
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0018BA3C File Offset: 0x00189C3C
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0018BA4C File Offset: 0x00189C4C
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

		// Token: 0x0600057D RID: 1405 RVA: 0x0018BA5C File Offset: 0x00189C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0018BA6C File Offset: 0x00189C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TeleportPlayerAnswerRequest other)
		{
			return true;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0018BA7C File Offset: 0x00189C7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0018BA8C File Offset: 0x00189C8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0018BA9C File Offset: 0x00189C9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0018BAAC File Offset: 0x00189CAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0018BABC File Offset: 0x00189CBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0018BACC File Offset: 0x00189CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TeleportPlayerAnswerRequest other)
		{
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0018BADC File Offset: 0x00189CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0018BAEC File Offset: 0x00189CEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0018BAFC File Offset: 0x00189CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TeleportPlayerAnswerRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					TeleportPlayerAnswerRequest._parser = new MessageParser<TeleportPlayerAnswerRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0018BBC8 File Offset: 0x00189DC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i9lWOWOKPtrC31bawV5e()
		{
			return true;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0018BBD0 File Offset: 0x00189DD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TeleportPlayerAnswerRequest sPB7d2OKS32KRyktgGJY()
		{
			return null;
		}

		// Token: 0x04000215 RID: 533
		private static readonly MessageParser<TeleportPlayerAnswerRequest> _parser;

		// Token: 0x04000216 RID: 534
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000217 RID: 535
		public const int AcceptFieldNumber = 1;

		// Token: 0x04000218 RID: 536
		private bool accept_;

		// Token: 0x04000219 RID: 537
		private static TeleportPlayerAnswerRequest kJZwt7OKieKRT5e0MNKP;
	}
}
