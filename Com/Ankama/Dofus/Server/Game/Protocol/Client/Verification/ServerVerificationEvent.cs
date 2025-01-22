using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Client.Verification
{
	// Token: 0x020008AE RID: 2222
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ServerVerificationEvent : IMessage<ServerVerificationEvent>, IMessage, IEquatable<ServerVerificationEvent>, IDeepCloneable<ServerVerificationEvent>, IBufferMessage
	{
		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06006BEC RID: 27628 RVA: 0x00231E4C File Offset: 0x0023004C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ServerVerificationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06006BED RID: 27629 RVA: 0x00231E5C File Offset: 0x0023005C
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

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06006BEE RID: 27630 RVA: 0x00231E6C File Offset: 0x0023006C
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

		// Token: 0x06006BEF RID: 27631 RVA: 0x00231E7C File Offset: 0x0023007C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerVerificationEvent()
		{
		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x00231E8C File Offset: 0x0023008C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerVerificationEvent(ServerVerificationEvent other)
		{
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x00231E9C File Offset: 0x0023009C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerVerificationEvent Clone()
		{
			return null;
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x00231EAC File Offset: 0x002300AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x00231EBC File Offset: 0x002300BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ServerVerificationEvent other)
		{
			return true;
		}

		// Token: 0x06006BF4 RID: 27636 RVA: 0x00231ECC File Offset: 0x002300CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006BF5 RID: 27637 RVA: 0x00231EDC File Offset: 0x002300DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006BF6 RID: 27638 RVA: 0x00231EEC File Offset: 0x002300EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006BF7 RID: 27639 RVA: 0x00231EFC File Offset: 0x002300FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006BF8 RID: 27640 RVA: 0x00231F0C File Offset: 0x0023010C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006BF9 RID: 27641 RVA: 0x00231F1C File Offset: 0x0023011C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ServerVerificationEvent other)
		{
		}

		// Token: 0x06006BFA RID: 27642 RVA: 0x00231F2C File Offset: 0x0023012C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006BFB RID: 27643 RVA: 0x00231F3C File Offset: 0x0023013C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006BFC RID: 27644 RVA: 0x00231F4C File Offset: 0x0023014C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ServerVerificationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ServerVerificationEvent._parser = new MessageParser<ServerVerificationEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
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
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006BFD RID: 27645 RVA: 0x00232030 File Offset: 0x00230230
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VQPCBRJmYeYSZukIHC8c()
		{
			return true;
		}

		// Token: 0x06006BFE RID: 27646 RVA: 0x00232038 File Offset: 0x00230238
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ServerVerificationEvent ywk8Q7Jmb1nMNG8B0cSV()
		{
			return null;
		}

		// Token: 0x040025AE RID: 9646
		private static readonly MessageParser<ServerVerificationEvent> _parser;

		// Token: 0x040025AF RID: 9647
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025B0 RID: 9648
		internal static ServerVerificationEvent Tlkdd6JmH55JliIHCkHh;
	}
}
