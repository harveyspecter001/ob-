using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection
{
	// Token: 0x0200089F RID: 2207
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReconnectToGameServerEvent : IMessage<ReconnectToGameServerEvent>, IMessage, IEquatable<ReconnectToGameServerEvent>, IDeepCloneable<ReconnectToGameServerEvent>, IBufferMessage
	{
		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x06006B2F RID: 27439 RVA: 0x00230B40 File Offset: 0x0022ED40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReconnectToGameServerEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06006B30 RID: 27440 RVA: 0x00230B50 File Offset: 0x0022ED50
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

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06006B31 RID: 27441 RVA: 0x00230B60 File Offset: 0x0022ED60
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

		// Token: 0x06006B32 RID: 27442 RVA: 0x00230B70 File Offset: 0x0022ED70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReconnectToGameServerEvent()
		{
		}

		// Token: 0x06006B33 RID: 27443 RVA: 0x00230B80 File Offset: 0x0022ED80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReconnectToGameServerEvent(ReconnectToGameServerEvent other)
		{
		}

		// Token: 0x06006B34 RID: 27444 RVA: 0x00230B90 File Offset: 0x0022ED90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReconnectToGameServerEvent Clone()
		{
			return null;
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06006B35 RID: 27445 RVA: 0x00230BA0 File Offset: 0x0022EDA0
		// (set) Token: 0x06006B36 RID: 27446 RVA: 0x00230BB0 File Offset: 0x0022EDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ValidToken
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

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06006B37 RID: 27447 RVA: 0x00230BC0 File Offset: 0x0022EDC0
		// (set) Token: 0x06006B38 RID: 27448 RVA: 0x00230BD0 File Offset: 0x0022EDD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Token
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

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06006B39 RID: 27449 RVA: 0x00230BE0 File Offset: 0x0022EDE0
		// (set) Token: 0x06006B3A RID: 27450 RVA: 0x00230BF0 File Offset: 0x0022EDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ServerId
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

		// Token: 0x06006B3B RID: 27451 RVA: 0x00230C00 File Offset: 0x0022EE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006B3C RID: 27452 RVA: 0x00230C10 File Offset: 0x0022EE10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ReconnectToGameServerEvent other)
		{
			return true;
		}

		// Token: 0x06006B3D RID: 27453 RVA: 0x00230C20 File Offset: 0x0022EE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006B3E RID: 27454 RVA: 0x00230C30 File Offset: 0x0022EE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x00230C40 File Offset: 0x0022EE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006B40 RID: 27456 RVA: 0x00230C50 File Offset: 0x0022EE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006B41 RID: 27457 RVA: 0x00230C60 File Offset: 0x0022EE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006B42 RID: 27458 RVA: 0x00230C70 File Offset: 0x0022EE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ReconnectToGameServerEvent other)
		{
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x00230C80 File Offset: 0x0022EE80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006B44 RID: 27460 RVA: 0x00230C90 File Offset: 0x0022EE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006B45 RID: 27461 RVA: 0x00230CA0 File Offset: 0x0022EEA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ReconnectToGameServerEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ReconnectToGameServerEvent._parser = new MessageParser<ReconnectToGameServerEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06006B46 RID: 27462 RVA: 0x00230D84 File Offset: 0x0022EF84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hEpfWPJmcDrwRMYPpxOJ()
		{
			return true;
		}

		// Token: 0x06006B47 RID: 27463 RVA: 0x00230D8C File Offset: 0x0022EF8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ReconnectToGameServerEvent SFvxtdJmUPmHaQqxRii4()
		{
			return null;
		}

		// Token: 0x04002576 RID: 9590
		private static readonly MessageParser<ReconnectToGameServerEvent> _parser;

		// Token: 0x04002577 RID: 9591
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002578 RID: 9592
		public const int ValidTokenFieldNumber = 1;

		// Token: 0x04002579 RID: 9593
		private bool validToken_;

		// Token: 0x0400257A RID: 9594
		public const int TokenFieldNumber = 2;

		// Token: 0x0400257B RID: 9595
		private string token_;

		// Token: 0x0400257C RID: 9596
		public const int ServerIdFieldNumber = 3;

		// Token: 0x0400257D RID: 9597
		private int serverId_;

		// Token: 0x0400257E RID: 9598
		private static ReconnectToGameServerEvent r4KSaLJmlZpFcTCW9Rj4;
	}
}
