using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C4F RID: 3151
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SurrenderVoteCastRequest : IMessage<SurrenderVoteCastRequest>, IMessage, IEquatable<SurrenderVoteCastRequest>, IDeepCloneable<SurrenderVoteCastRequest>, IBufferMessage
	{
		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x06009758 RID: 38744 RVA: 0x00278158 File Offset: 0x00276358
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SurrenderVoteCastRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06009759 RID: 38745 RVA: 0x00278168 File Offset: 0x00276368
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

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x0600975A RID: 38746 RVA: 0x00278178 File Offset: 0x00276378
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

		// Token: 0x0600975B RID: 38747 RVA: 0x00278188 File Offset: 0x00276388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderVoteCastRequest()
		{
		}

		// Token: 0x0600975C RID: 38748 RVA: 0x00278198 File Offset: 0x00276398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderVoteCastRequest(SurrenderVoteCastRequest other)
		{
		}

		// Token: 0x0600975D RID: 38749 RVA: 0x002781A8 File Offset: 0x002763A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderVoteCastRequest Clone()
		{
			return null;
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x0600975E RID: 38750 RVA: 0x002781B8 File Offset: 0x002763B8
		// (set) Token: 0x0600975F RID: 38751 RVA: 0x002781C8 File Offset: 0x002763C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Vote
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

		// Token: 0x06009760 RID: 38752 RVA: 0x002781D8 File Offset: 0x002763D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009761 RID: 38753 RVA: 0x002781E8 File Offset: 0x002763E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SurrenderVoteCastRequest other)
		{
			return true;
		}

		// Token: 0x06009762 RID: 38754 RVA: 0x002781F8 File Offset: 0x002763F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009763 RID: 38755 RVA: 0x00278208 File Offset: 0x00276408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009764 RID: 38756 RVA: 0x00278218 File Offset: 0x00276418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009765 RID: 38757 RVA: 0x00278228 File Offset: 0x00276428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009766 RID: 38758 RVA: 0x00278238 File Offset: 0x00276438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009767 RID: 38759 RVA: 0x00278248 File Offset: 0x00276448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SurrenderVoteCastRequest other)
		{
		}

		// Token: 0x06009768 RID: 38760 RVA: 0x00278258 File Offset: 0x00276458
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009769 RID: 38761 RVA: 0x00278268 File Offset: 0x00276468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600976A RID: 38762 RVA: 0x00278278 File Offset: 0x00276478
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SurrenderVoteCastRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				SurrenderVoteCastRequest._parser = new MessageParser<SurrenderVoteCastRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600976B RID: 38763 RVA: 0x0027835C File Offset: 0x0027655C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p4DuQTJXqhNU4x39GE7i()
		{
			return true;
		}

		// Token: 0x0600976C RID: 38764 RVA: 0x00278364 File Offset: 0x00276564
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SurrenderVoteCastRequest tI5hS8JXFpVZr3UBtHsE()
		{
			return null;
		}

		// Token: 0x0400383D RID: 14397
		private static readonly MessageParser<SurrenderVoteCastRequest> _parser;

		// Token: 0x0400383E RID: 14398
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400383F RID: 14399
		public const int VoteFieldNumber = 1;

		// Token: 0x04003840 RID: 14400
		private bool vote_;

		// Token: 0x04003841 RID: 14401
		internal static SurrenderVoteCastRequest wMjObFJXZo1u4JDkWUhK;
	}
}
