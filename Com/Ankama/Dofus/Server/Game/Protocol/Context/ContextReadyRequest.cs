using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x02000805 RID: 2053
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContextReadyRequest : IMessage<ContextReadyRequest>, IMessage, IEquatable<ContextReadyRequest>, IDeepCloneable<ContextReadyRequest>, IBufferMessage
	{
		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060063F0 RID: 25584 RVA: 0x00225FEC File Offset: 0x002241EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContextReadyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060063F1 RID: 25585 RVA: 0x00225FFC File Offset: 0x002241FC
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

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060063F2 RID: 25586 RVA: 0x0022600C File Offset: 0x0022420C
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

		// Token: 0x060063F3 RID: 25587 RVA: 0x0022601C File Offset: 0x0022421C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextReadyRequest()
		{
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x0022602C File Offset: 0x0022422C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextReadyRequest(ContextReadyRequest other)
		{
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x0022603C File Offset: 0x0022423C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextReadyRequest Clone()
		{
			return null;
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x060063F6 RID: 25590 RVA: 0x0022604C File Offset: 0x0022424C
		// (set) Token: 0x060063F7 RID: 25591 RVA: 0x0022605C File Offset: 0x0022425C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long MapId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x0022606C File Offset: 0x0022426C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x0022607C File Offset: 0x0022427C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContextReadyRequest other)
		{
			return true;
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x0022608C File Offset: 0x0022428C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x0022609C File Offset: 0x0022429C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x002260AC File Offset: 0x002242AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x002260BC File Offset: 0x002242BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x002260CC File Offset: 0x002242CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x002260DC File Offset: 0x002242DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContextReadyRequest other)
		{
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x002260EC File Offset: 0x002242EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x002260FC File Offset: 0x002242FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006402 RID: 25602 RVA: 0x0022610C File Offset: 0x0022430C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContextReadyRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b != 0)
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
					ContextReadyRequest._parser = new MessageParser<ContextReadyRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
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

		// Token: 0x06006403 RID: 25603 RVA: 0x002261D8 File Offset: 0x002243D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tAj3TDOzohwO5JDmRoUE()
		{
			return true;
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x002261E0 File Offset: 0x002243E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContextReadyRequest cSKfE3Oz1IMxcS7aLm6n()
		{
			return null;
		}

		// Token: 0x04002328 RID: 9000
		private static readonly MessageParser<ContextReadyRequest> _parser;

		// Token: 0x04002329 RID: 9001
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400232A RID: 9002
		public const int MapIdFieldNumber = 1;

		// Token: 0x0400232B RID: 9003
		private long mapId_;

		// Token: 0x0400232C RID: 9004
		internal static ContextReadyRequest puUfqdOzvCCQCYFVR7M3;
	}
}
