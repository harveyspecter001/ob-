using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol
{
	// Token: 0x02000026 RID: 38
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameMessage : IMessage<GameMessage>, IMessage, IEquatable<GameMessage>, IDeepCloneable<GameMessage>, IBufferMessage
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00184368 File Offset: 0x00182568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameMessage> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00184378 File Offset: 0x00182578
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00184388 File Offset: 0x00182588
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

		// Token: 0x0600014E RID: 334 RVA: 0x00184398 File Offset: 0x00182598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameMessage()
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x001843A8 File Offset: 0x001825A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameMessage(GameMessage other)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x001843B8 File Offset: 0x001825B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameMessage Clone()
		{
			return null;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000151 RID: 337 RVA: 0x001843C8 File Offset: 0x001825C8
		// (set) Token: 0x06000152 RID: 338 RVA: 0x001843D8 File Offset: 0x001825D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Request Request
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

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000153 RID: 339 RVA: 0x001843E8 File Offset: 0x001825E8
		// (set) Token: 0x06000154 RID: 340 RVA: 0x001843F8 File Offset: 0x001825F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Response Response
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

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00184408 File Offset: 0x00182608
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00184418 File Offset: 0x00182618
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Event Event
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

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00184428 File Offset: 0x00182628
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GameMessage.ContentOneofCase ContentCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (GameMessage.ContentOneofCase)null;
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0018443C File Offset: 0x0018263C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearContent()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0018444C File Offset: 0x0018264C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0018445C File Offset: 0x0018265C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameMessage other)
		{
			return true;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0018446C File Offset: 0x0018266C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0018447C File Offset: 0x0018267C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0018448C File Offset: 0x0018268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0018449C File Offset: 0x0018269C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x001844AC File Offset: 0x001826AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x001844BC File Offset: 0x001826BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameMessage other)
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x001844CC File Offset: 0x001826CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x001844DC File Offset: 0x001826DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x001844EC File Offset: 0x001826EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameMessage()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GameMessage._parser = new MessageParser<GameMessage>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x001845B8 File Offset: 0x001827B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EQ8BKtOjnd8F2x1La8yl()
		{
			return true;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x001845C0 File Offset: 0x001827C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameMessage QKdNUHOjmdY3ah3iJgJi()
		{
			return null;
		}

		// Token: 0x0400008E RID: 142
		private static readonly MessageParser<GameMessage> _parser;

		// Token: 0x0400008F RID: 143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000090 RID: 144
		public const int RequestFieldNumber = 1;

		// Token: 0x04000091 RID: 145
		public const int ResponseFieldNumber = 2;

		// Token: 0x04000092 RID: 146
		public const int EventFieldNumber = 3;

		// Token: 0x04000093 RID: 147
		private object content_;

		// Token: 0x04000094 RID: 148
		private GameMessage.ContentOneofCase contentCase_;

		// Token: 0x04000095 RID: 149
		private static GameMessage JW52hXOjfXvVIwhT9x7L;

		// Token: 0x02000027 RID: 39
		public enum ContentOneofCase
		{
			// Token: 0x04000097 RID: 151
			None,
			// Token: 0x04000098 RID: 152
			Request,
			// Token: 0x04000099 RID: 153
			Response,
			// Token: 0x0400009A RID: 154
			Event
		}
	}
}
