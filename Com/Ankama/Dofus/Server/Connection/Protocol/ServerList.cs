using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E27 RID: 3623
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ServerList : IMessage<ServerList>, IMessage, IEquatable<ServerList>, IDeepCloneable<ServerList>, IBufferMessage
	{
		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x0600AE2F RID: 44591 RVA: 0x0029FC74 File Offset: 0x0029DE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ServerList> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x0600AE30 RID: 44592 RVA: 0x0029FC84 File Offset: 0x0029DE84
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

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x0600AE31 RID: 44593 RVA: 0x0029FC94 File Offset: 0x0029DE94
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

		// Token: 0x0600AE32 RID: 44594 RVA: 0x0029FCA4 File Offset: 0x0029DEA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerList()
		{
		}

		// Token: 0x0600AE33 RID: 44595 RVA: 0x0029FCB4 File Offset: 0x0029DEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerList(ServerList other)
		{
		}

		// Token: 0x0600AE34 RID: 44596 RVA: 0x0029FCC4 File Offset: 0x0029DEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerList Clone()
		{
			return null;
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x0600AE35 RID: 44597 RVA: 0x0029FCD4 File Offset: 0x0029DED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ServerInformation> Servers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x0600AE36 RID: 44598 RVA: 0x0029FCE4 File Offset: 0x0029DEE4
		// (set) Token: 0x0600AE37 RID: 44599 RVA: 0x0029FCF4 File Offset: 0x0029DEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxSlotByType
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

		// Token: 0x0600AE38 RID: 44600 RVA: 0x0029FD04 File Offset: 0x0029DF04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AE39 RID: 44601 RVA: 0x0029FD14 File Offset: 0x0029DF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ServerList other)
		{
			return true;
		}

		// Token: 0x0600AE3A RID: 44602 RVA: 0x0029FD24 File Offset: 0x0029DF24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AE3B RID: 44603 RVA: 0x0029FD34 File Offset: 0x0029DF34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AE3C RID: 44604 RVA: 0x0029FD44 File Offset: 0x0029DF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AE3D RID: 44605 RVA: 0x0029FD54 File Offset: 0x0029DF54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AE3E RID: 44606 RVA: 0x0029FD64 File Offset: 0x0029DF64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AE3F RID: 44607 RVA: 0x0029FD74 File Offset: 0x0029DF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ServerList other)
		{
		}

		// Token: 0x0600AE40 RID: 44608 RVA: 0x0029FD84 File Offset: 0x0029DF84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AE41 RID: 44609 RVA: 0x0029FD94 File Offset: 0x0029DF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AE42 RID: 44610 RVA: 0x0029FDA4 File Offset: 0x0029DFA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ServerList()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					ServerList._repeated_servers_codec = FieldCodec.ForMessage<ServerInformation>(10U, otb1bj3Nmo8iYCIGqQi8.XVInXhlssT(otb1bj3Nmo8iYCIGqQi8.JV83NAss7hs));
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					ServerList._parser = new MessageParser<ServerList>(() => null);
					num2 = 3;
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 5;
			}
		}

		// Token: 0x0600AE43 RID: 44611 RVA: 0x0029FE94 File Offset: 0x0029E094
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WX5EE8JUFKEwTvjhQGcN()
		{
			return true;
		}

		// Token: 0x0600AE44 RID: 44612 RVA: 0x0029FE9C File Offset: 0x0029E09C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ServerList RnToAcJUzCSyxPwtgIkf()
		{
			return null;
		}

		// Token: 0x0400401A RID: 16410
		private static readonly MessageParser<ServerList> _parser;

		// Token: 0x0400401B RID: 16411
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400401C RID: 16412
		public const int ServersFieldNumber = 1;

		// Token: 0x0400401D RID: 16413
		private static readonly FieldCodec<ServerInformation> _repeated_servers_codec;

		// Token: 0x0400401E RID: 16414
		private readonly RepeatedField<ServerInformation> servers_;

		// Token: 0x0400401F RID: 16415
		public const int MaxSlotByTypeFieldNumber = 2;

		// Token: 0x04004020 RID: 16416
		private int maxSlotByType_;

		// Token: 0x04004021 RID: 16417
		internal static ServerList ua0JhAJUq9xiY5GRWp6K;
	}
}
