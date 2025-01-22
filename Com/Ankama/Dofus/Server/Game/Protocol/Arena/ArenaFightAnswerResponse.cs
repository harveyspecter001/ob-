using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C10 RID: 3088
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaFightAnswerResponse : IMessage<ArenaFightAnswerResponse>, IMessage, IEquatable<ArenaFightAnswerResponse>, IDeepCloneable<ArenaFightAnswerResponse>, IBufferMessage
	{
		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x0600945F RID: 37983 RVA: 0x002761A4 File Offset: 0x002743A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArenaFightAnswerResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06009460 RID: 37984 RVA: 0x002761B4 File Offset: 0x002743B4
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

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06009461 RID: 37985 RVA: 0x002761C4 File Offset: 0x002743C4
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

		// Token: 0x06009462 RID: 37986 RVA: 0x002761D4 File Offset: 0x002743D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFightAnswerResponse()
		{
		}

		// Token: 0x06009463 RID: 37987 RVA: 0x002761E4 File Offset: 0x002743E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFightAnswerResponse(ArenaFightAnswerResponse other)
		{
		}

		// Token: 0x06009464 RID: 37988 RVA: 0x002761F4 File Offset: 0x002743F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFightAnswerResponse Clone()
		{
			return null;
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06009465 RID: 37989 RVA: 0x00276204 File Offset: 0x00274404
		// (set) Token: 0x06009466 RID: 37990 RVA: 0x00276214 File Offset: 0x00274414
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Acknowledged
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

		// Token: 0x06009467 RID: 37991 RVA: 0x00276224 File Offset: 0x00274424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009468 RID: 37992 RVA: 0x00276234 File Offset: 0x00274434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaFightAnswerResponse other)
		{
			return true;
		}

		// Token: 0x06009469 RID: 37993 RVA: 0x00276244 File Offset: 0x00274444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600946A RID: 37994 RVA: 0x00276254 File Offset: 0x00274454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600946B RID: 37995 RVA: 0x00276264 File Offset: 0x00274464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600946C RID: 37996 RVA: 0x00276274 File Offset: 0x00274474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600946D RID: 37997 RVA: 0x00276284 File Offset: 0x00274484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600946E RID: 37998 RVA: 0x00276294 File Offset: 0x00274494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaFightAnswerResponse other)
		{
		}

		// Token: 0x0600946F RID: 37999 RVA: 0x002762A4 File Offset: 0x002744A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009470 RID: 38000 RVA: 0x002762B4 File Offset: 0x002744B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009471 RID: 38001 RVA: 0x002762C4 File Offset: 0x002744C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaFightAnswerResponse()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ArenaFightAnswerResponse._parser = new MessageParser<ArenaFightAnswerResponse>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06009472 RID: 38002 RVA: 0x002763A8 File Offset: 0x002745A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EIEMKmJXXw3wC2NW4qI3()
		{
			return true;
		}

		// Token: 0x06009473 RID: 38003 RVA: 0x002763B0 File Offset: 0x002745B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaFightAnswerResponse LWS92qJXNrkL37iZafdT()
		{
			return null;
		}

		// Token: 0x04003738 RID: 14136
		private static readonly MessageParser<ArenaFightAnswerResponse> _parser;

		// Token: 0x04003739 RID: 14137
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400373A RID: 14138
		public const int AcknowledgedFieldNumber = 1;

		// Token: 0x0400373B RID: 14139
		private bool acknowledged_;

		// Token: 0x0400373C RID: 14140
		internal static ArenaFightAnswerResponse w8lDFTJXEtuVQ7CMJPNP;
	}
}
