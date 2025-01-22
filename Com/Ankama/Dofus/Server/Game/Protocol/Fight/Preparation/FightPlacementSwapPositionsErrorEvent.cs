using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006AB RID: 1707
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightPlacementSwapPositionsErrorEvent : IMessage<FightPlacementSwapPositionsErrorEvent>, IMessage, IEquatable<FightPlacementSwapPositionsErrorEvent>, IDeepCloneable<FightPlacementSwapPositionsErrorEvent>, IBufferMessage
	{
		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06005358 RID: 21336 RVA: 0x00209998 File Offset: 0x00207B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightPlacementSwapPositionsErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06005359 RID: 21337 RVA: 0x002099A8 File Offset: 0x00207BA8
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

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x0600535A RID: 21338 RVA: 0x002099B8 File Offset: 0x00207BB8
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

		// Token: 0x0600535B RID: 21339 RVA: 0x002099C8 File Offset: 0x00207BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsErrorEvent()
		{
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x002099D8 File Offset: 0x00207BD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsErrorEvent(FightPlacementSwapPositionsErrorEvent other)
		{
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x002099E8 File Offset: 0x00207BE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x002099F8 File Offset: 0x00207BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x00209A08 File Offset: 0x00207C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightPlacementSwapPositionsErrorEvent other)
		{
			return true;
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x00209A18 File Offset: 0x00207C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x00209A28 File Offset: 0x00207C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x00209A38 File Offset: 0x00207C38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x00209A48 File Offset: 0x00207C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x00209A58 File Offset: 0x00207C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x00209A68 File Offset: 0x00207C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightPlacementSwapPositionsErrorEvent other)
		{
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x00209A78 File Offset: 0x00207C78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005367 RID: 21351 RVA: 0x00209A88 File Offset: 0x00207C88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x00209A98 File Offset: 0x00207C98
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightPlacementSwapPositionsErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a != 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					FightPlacementSwapPositionsErrorEvent._parser = new MessageParser<FightPlacementSwapPositionsErrorEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x00209B7C File Offset: 0x00207D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Xm7OZbOSRReU6puyfrFZ()
		{
			return true;
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x00209B84 File Offset: 0x00207D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightPlacementSwapPositionsErrorEvent RpG4v5OSO8Y9kUuhiFeN()
		{
			return null;
		}

		// Token: 0x04001D61 RID: 7521
		private static readonly MessageParser<FightPlacementSwapPositionsErrorEvent> _parser;

		// Token: 0x04001D62 RID: 7522
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D63 RID: 7523
		internal static FightPlacementSwapPositionsErrorEvent o1QBnnOS3sy3qwxjoydb;
	}
}
