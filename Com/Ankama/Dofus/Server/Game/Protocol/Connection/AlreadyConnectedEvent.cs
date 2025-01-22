using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection
{
	// Token: 0x0200089D RID: 2205
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlreadyConnectedEvent : IMessage<AlreadyConnectedEvent>, IMessage, IEquatable<AlreadyConnectedEvent>, IDeepCloneable<AlreadyConnectedEvent>, IBufferMessage
	{
		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06006B17 RID: 27415 RVA: 0x0023094C File Offset: 0x0022EB4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AlreadyConnectedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06006B18 RID: 27416 RVA: 0x0023095C File Offset: 0x0022EB5C
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

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06006B19 RID: 27417 RVA: 0x0023096C File Offset: 0x0022EB6C
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

		// Token: 0x06006B1A RID: 27418 RVA: 0x0023097C File Offset: 0x0022EB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlreadyConnectedEvent()
		{
		}

		// Token: 0x06006B1B RID: 27419 RVA: 0x0023098C File Offset: 0x0022EB8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlreadyConnectedEvent(AlreadyConnectedEvent other)
		{
		}

		// Token: 0x06006B1C RID: 27420 RVA: 0x0023099C File Offset: 0x0022EB9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlreadyConnectedEvent Clone()
		{
			return null;
		}

		// Token: 0x06006B1D RID: 27421 RVA: 0x002309AC File Offset: 0x0022EBAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006B1E RID: 27422 RVA: 0x002309BC File Offset: 0x0022EBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AlreadyConnectedEvent other)
		{
			return true;
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x002309CC File Offset: 0x0022EBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x002309DC File Offset: 0x0022EBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006B21 RID: 27425 RVA: 0x002309EC File Offset: 0x0022EBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006B22 RID: 27426 RVA: 0x002309FC File Offset: 0x0022EBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006B23 RID: 27427 RVA: 0x00230A0C File Offset: 0x0022EC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006B24 RID: 27428 RVA: 0x00230A1C File Offset: 0x0022EC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AlreadyConnectedEvent other)
		{
		}

		// Token: 0x06006B25 RID: 27429 RVA: 0x00230A2C File Offset: 0x0022EC2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006B26 RID: 27430 RVA: 0x00230A3C File Offset: 0x0022EC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006B27 RID: 27431 RVA: 0x00230A4C File Offset: 0x0022EC4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AlreadyConnectedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AlreadyConnectedEvent._parser = new MessageParser<AlreadyConnectedEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
					{
						num2 = 2;
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

		// Token: 0x06006B28 RID: 27432 RVA: 0x00230B30 File Offset: 0x0022ED30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KovQ2gJmIvXyYWaG1J8V()
		{
			return true;
		}

		// Token: 0x06006B29 RID: 27433 RVA: 0x00230B38 File Offset: 0x0022ED38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AlreadyConnectedEvent RdmZaWJmkhKRobw8bQg6()
		{
			return null;
		}

		// Token: 0x04002571 RID: 9585
		private static readonly MessageParser<AlreadyConnectedEvent> _parser;

		// Token: 0x04002572 RID: 9586
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002573 RID: 9587
		internal static AlreadyConnectedEvent keZ6ScJmKnZIY3ZrZ1tc;
	}
}
