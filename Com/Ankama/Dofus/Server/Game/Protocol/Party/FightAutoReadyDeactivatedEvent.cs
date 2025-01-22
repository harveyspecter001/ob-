using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002D0 RID: 720
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightAutoReadyDeactivatedEvent : IMessage<FightAutoReadyDeactivatedEvent>, IMessage, IEquatable<FightAutoReadyDeactivatedEvent>, IDeepCloneable<FightAutoReadyDeactivatedEvent>, IBufferMessage
	{
		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x001BB034 File Offset: 0x001B9234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightAutoReadyDeactivatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x001BB044 File Offset: 0x001B9244
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

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x001BB054 File Offset: 0x001B9254
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

		// Token: 0x06002145 RID: 8517 RVA: 0x001BB064 File Offset: 0x001B9264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyDeactivatedEvent()
		{
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x001BB074 File Offset: 0x001B9274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyDeactivatedEvent(FightAutoReadyDeactivatedEvent other)
		{
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x001BB084 File Offset: 0x001B9284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyDeactivatedEvent Clone()
		{
			return null;
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x001BB094 File Offset: 0x001B9294
		// (set) Token: 0x06002149 RID: 8521 RVA: 0x001BB0A4 File Offset: 0x001B92A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x0600214A RID: 8522 RVA: 0x001BB0B4 File Offset: 0x001B92B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x001BB0C4 File Offset: 0x001B92C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightAutoReadyDeactivatedEvent other)
		{
			return true;
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x001BB0D4 File Offset: 0x001B92D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x001BB0E4 File Offset: 0x001B92E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x001BB0F4 File Offset: 0x001B92F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x001BB104 File Offset: 0x001B9304
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x001BB114 File Offset: 0x001B9314
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x001BB124 File Offset: 0x001B9324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightAutoReadyDeactivatedEvent other)
		{
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x001BB134 File Offset: 0x001B9334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x001BB144 File Offset: 0x001B9344
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x001BB154 File Offset: 0x001B9354
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightAutoReadyDeactivatedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						FightAutoReadyDeactivatedEvent._parser = new MessageParser<FightAutoReadyDeactivatedEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						goto IL_98;
					}
					return;
				}
				IL_98:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x001BB23C File Offset: 0x001B943C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lyZn7KO6wG8GfRxaW1sE()
		{
			return true;
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x001BB244 File Offset: 0x001B9444
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightAutoReadyDeactivatedEvent FdXQO6O6Q5y5tw0fOcxf()
		{
			return null;
		}

		// Token: 0x04000B9F RID: 2975
		private static readonly MessageParser<FightAutoReadyDeactivatedEvent> _parser;

		// Token: 0x04000BA0 RID: 2976
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BA1 RID: 2977
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04000BA2 RID: 2978
		private long playerId_;

		// Token: 0x04000BA3 RID: 2979
		private static FightAutoReadyDeactivatedEvent YnKlvHO6tBqPQwB33ZiY;
	}
}
