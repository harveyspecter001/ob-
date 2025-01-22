using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E2D RID: 3629
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Server : IMessage<Server>, IMessage, IEquatable<Server>, IDeepCloneable<Server>, IBufferMessage
	{
		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x0600AE68 RID: 44648 RVA: 0x002A0110 File Offset: 0x0029E310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Server> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x0600AE69 RID: 44649 RVA: 0x002A0120 File Offset: 0x0029E320
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

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x0600AE6A RID: 44650 RVA: 0x002A0130 File Offset: 0x0029E330
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

		// Token: 0x0600AE6B RID: 44651 RVA: 0x002A0140 File Offset: 0x0029E340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Server()
		{
		}

		// Token: 0x0600AE6C RID: 44652 RVA: 0x002A0150 File Offset: 0x0029E350
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Server(Server other)
		{
		}

		// Token: 0x0600AE6D RID: 44653 RVA: 0x002A0160 File Offset: 0x0029E360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Server Clone()
		{
			return null;
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x0600AE6E RID: 44654 RVA: 0x002A0170 File Offset: 0x0029E370
		// (set) Token: 0x0600AE6F RID: 44655 RVA: 0x002A0180 File Offset: 0x0029E380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x0600AE70 RID: 44656 RVA: 0x002A0190 File Offset: 0x0029E390
		// (set) Token: 0x0600AE71 RID: 44657 RVA: 0x002A01A4 File Offset: 0x0029E3A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Server.Types.Status Status
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Server.Types.Status)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x0600AE72 RID: 44658 RVA: 0x002A01B4 File Offset: 0x0029E3B4
		// (set) Token: 0x0600AE73 RID: 44659 RVA: 0x002A01C4 File Offset: 0x0029E3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MonoAccount
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

		// Token: 0x0600AE74 RID: 44660 RVA: 0x002A01D4 File Offset: 0x0029E3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AE75 RID: 44661 RVA: 0x002A01E4 File Offset: 0x0029E3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Server other)
		{
			return true;
		}

		// Token: 0x0600AE76 RID: 44662 RVA: 0x002A01F4 File Offset: 0x0029E3F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AE77 RID: 44663 RVA: 0x002A0204 File Offset: 0x0029E404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AE78 RID: 44664 RVA: 0x002A0214 File Offset: 0x0029E414
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AE79 RID: 44665 RVA: 0x002A0224 File Offset: 0x0029E424
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AE7A RID: 44666 RVA: 0x002A0234 File Offset: 0x0029E434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AE7B RID: 44667 RVA: 0x002A0244 File Offset: 0x0029E444
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Server other)
		{
		}

		// Token: 0x0600AE7C RID: 44668 RVA: 0x002A0254 File Offset: 0x0029E454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AE7D RID: 44669 RVA: 0x002A0264 File Offset: 0x0029E464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AE7E RID: 44670 RVA: 0x002A0274 File Offset: 0x0029E474
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Server()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					Server._parser = new MessageParser<Server>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x0600AE7F RID: 44671 RVA: 0x002A0358 File Offset: 0x0029E558
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T9SE4sJvBRIgbWXoFlsC()
		{
			return true;
		}

		// Token: 0x0600AE80 RID: 44672 RVA: 0x002A0360 File Offset: 0x0029E560
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Server iSh8gRJveXd6pUP3Sg6H()
		{
			return null;
		}

		// Token: 0x04004035 RID: 16437
		private static readonly MessageParser<Server> _parser;

		// Token: 0x04004036 RID: 16438
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004037 RID: 16439
		public const int IdFieldNumber = 1;

		// Token: 0x04004038 RID: 16440
		private int id_;

		// Token: 0x04004039 RID: 16441
		public const int StatusFieldNumber = 2;

		// Token: 0x0400403A RID: 16442
		private Server.Types.Status status_;

		// Token: 0x0400403B RID: 16443
		public const int MonoAccountFieldNumber = 3;

		// Token: 0x0400403C RID: 16444
		private bool monoAccount_;

		// Token: 0x0400403D RID: 16445
		private static Server eDnpJhJvAv3PeJIGKgXy;

		// Token: 0x02000E2E RID: 3630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600AE81 RID: 44673 RVA: 0x002F41C4 File Offset: 0x002F23C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000E2F RID: 3631
			public enum Status
			{
				// Token: 0x0400403F RID: 16447
				[OriginalName("ONLINE")]
				Online,
				// Token: 0x04004040 RID: 16448
				[OriginalName("MAINTENANCE")]
				Maintenance
			}
		}
	}
}
