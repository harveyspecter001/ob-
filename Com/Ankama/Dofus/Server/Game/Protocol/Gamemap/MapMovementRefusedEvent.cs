using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x02000588 RID: 1416
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapMovementRefusedEvent : IMessage<MapMovementRefusedEvent>, IMessage, IEquatable<MapMovementRefusedEvent>, IDeepCloneable<MapMovementRefusedEvent>, IBufferMessage
	{
		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06004431 RID: 17457 RVA: 0x001F600C File Offset: 0x001F420C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapMovementRefusedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06004432 RID: 17458 RVA: 0x001F601C File Offset: 0x001F421C
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

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06004433 RID: 17459 RVA: 0x001F602C File Offset: 0x001F422C
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

		// Token: 0x06004434 RID: 17460 RVA: 0x001F603C File Offset: 0x001F423C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementRefusedEvent()
		{
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x001F604C File Offset: 0x001F424C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementRefusedEvent(MapMovementRefusedEvent other)
		{
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x001F605C File Offset: 0x001F425C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementRefusedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06004437 RID: 17463 RVA: 0x001F606C File Offset: 0x001F426C
		// (set) Token: 0x06004438 RID: 17464 RVA: 0x001F607C File Offset: 0x001F427C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CellX
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

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06004439 RID: 17465 RVA: 0x001F608C File Offset: 0x001F428C
		// (set) Token: 0x0600443A RID: 17466 RVA: 0x001F609C File Offset: 0x001F429C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CellY
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

		// Token: 0x0600443B RID: 17467 RVA: 0x001F60AC File Offset: 0x001F42AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x001F60BC File Offset: 0x001F42BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapMovementRefusedEvent other)
		{
			return true;
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x001F60CC File Offset: 0x001F42CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x001F60DC File Offset: 0x001F42DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x001F60EC File Offset: 0x001F42EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x001F60FC File Offset: 0x001F42FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x001F610C File Offset: 0x001F430C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x001F611C File Offset: 0x001F431C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapMovementRefusedEvent other)
		{
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x001F612C File Offset: 0x001F432C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x001F613C File Offset: 0x001F433C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x001F614C File Offset: 0x001F434C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapMovementRefusedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					MapMovementRefusedEvent._parser = new MessageParser<MapMovementRefusedEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x001F6230 File Offset: 0x001F4430
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PQFZDXOYNL0gwLR1hLoh()
		{
			return true;
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x001F6238 File Offset: 0x001F4438
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapMovementRefusedEvent aG5fDbOYxusxJkoZSdy8()
		{
			return null;
		}

		// Token: 0x04001770 RID: 6000
		private static readonly MessageParser<MapMovementRefusedEvent> _parser;

		// Token: 0x04001771 RID: 6001
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001772 RID: 6002
		public const int CellXFieldNumber = 1;

		// Token: 0x04001773 RID: 6003
		private int cellX_;

		// Token: 0x04001774 RID: 6004
		public const int CellYFieldNumber = 2;

		// Token: 0x04001775 RID: 6005
		private int cellY_;

		// Token: 0x04001776 RID: 6006
		private static MapMovementRefusedEvent fUqILKOYXnJER2o4WyPT;
	}
}
