using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x020005C3 RID: 1475
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameActionItemConsumedEvent : IMessage<GameActionItemConsumedEvent>, IMessage, IEquatable<GameActionItemConsumedEvent>, IDeepCloneable<GameActionItemConsumedEvent>, IBufferMessage
	{
		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06004721 RID: 18209 RVA: 0x001FE038 File Offset: 0x001FC238
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GameActionItemConsumedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06004722 RID: 18210 RVA: 0x001FE048 File Offset: 0x001FC248
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

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06004723 RID: 18211 RVA: 0x001FE058 File Offset: 0x001FC258
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

		// Token: 0x06004724 RID: 18212 RVA: 0x001FE068 File Offset: 0x001FC268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItemConsumedEvent()
		{
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x001FE078 File Offset: 0x001FC278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItemConsumedEvent(GameActionItemConsumedEvent other)
		{
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x001FE088 File Offset: 0x001FC288
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItemConsumedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06004727 RID: 18215 RVA: 0x001FE098 File Offset: 0x001FC298
		// (set) Token: 0x06004728 RID: 18216 RVA: 0x001FE0A8 File Offset: 0x001FC2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
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

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06004729 RID: 18217 RVA: 0x001FE0B8 File Offset: 0x001FC2B8
		// (set) Token: 0x0600472A RID: 18218 RVA: 0x001FE0C8 File Offset: 0x001FC2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionId
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

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x0600472B RID: 18219 RVA: 0x001FE0D8 File Offset: 0x001FC2D8
		// (set) Token: 0x0600472C RID: 18220 RVA: 0x001FE0E8 File Offset: 0x001FC2E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool AutomaticAction
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

		// Token: 0x0600472D RID: 18221 RVA: 0x001FE0F8 File Offset: 0x001FC2F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x001FE108 File Offset: 0x001FC308
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameActionItemConsumedEvent other)
		{
			return true;
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x001FE118 File Offset: 0x001FC318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x001FE128 File Offset: 0x001FC328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x001FE138 File Offset: 0x001FC338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x001FE148 File Offset: 0x001FC348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x001FE158 File Offset: 0x001FC358
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x001FE168 File Offset: 0x001FC368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameActionItemConsumedEvent other)
		{
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x001FE178 File Offset: 0x001FC378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x001FE188 File Offset: 0x001FC388
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x001FE198 File Offset: 0x001FC398
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameActionItemConsumedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					GameActionItemConsumedEvent._parser = new MessageParser<GameActionItemConsumedEvent>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x001FE264 File Offset: 0x001FC464
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UFDSgoObtv1xy0svyAsf()
		{
			return true;
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x001FE26C File Offset: 0x001FC46C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameActionItemConsumedEvent b25GcCObwO3BF4IlKs9f()
		{
			return null;
		}

		// Token: 0x040018A6 RID: 6310
		private static readonly MessageParser<GameActionItemConsumedEvent> _parser;

		// Token: 0x040018A7 RID: 6311
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018A8 RID: 6312
		public const int SuccessFieldNumber = 1;

		// Token: 0x040018A9 RID: 6313
		private bool success_;

		// Token: 0x040018AA RID: 6314
		public const int ActionIdFieldNumber = 2;

		// Token: 0x040018AB RID: 6315
		private int actionId_;

		// Token: 0x040018AC RID: 6316
		public const int AutomaticActionFieldNumber = 3;

		// Token: 0x040018AD RID: 6317
		private bool automaticAction_;

		// Token: 0x040018AE RID: 6318
		private static GameActionItemConsumedEvent hSc1xwObDDjwqq85i4jM;
	}
}
