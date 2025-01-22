using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x0200080D RID: 2061
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContextCreationEvent : IMessage<ContextCreationEvent>, IMessage, IEquatable<ContextCreationEvent>, IDeepCloneable<ContextCreationEvent>, IBufferMessage
	{
		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06006456 RID: 25686 RVA: 0x002267D4 File Offset: 0x002249D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ContextCreationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06006457 RID: 25687 RVA: 0x002267E4 File Offset: 0x002249E4
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

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06006458 RID: 25688 RVA: 0x002267F4 File Offset: 0x002249F4
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

		// Token: 0x06006459 RID: 25689 RVA: 0x00226804 File Offset: 0x00224A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextCreationEvent()
		{
		}

		// Token: 0x0600645A RID: 25690 RVA: 0x00226814 File Offset: 0x00224A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextCreationEvent(ContextCreationEvent other)
		{
		}

		// Token: 0x0600645B RID: 25691 RVA: 0x00226824 File Offset: 0x00224A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextCreationEvent Clone()
		{
			return null;
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x0600645C RID: 25692 RVA: 0x00226834 File Offset: 0x00224A34
		// (set) Token: 0x0600645D RID: 25693 RVA: 0x00226848 File Offset: 0x00224A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContextCreationEvent.Types.GameContext Context
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ContextCreationEvent.Types.GameContext)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600645E RID: 25694 RVA: 0x00226858 File Offset: 0x00224A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x00226868 File Offset: 0x00224A68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContextCreationEvent other)
		{
			return true;
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x00226878 File Offset: 0x00224A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006461 RID: 25697 RVA: 0x00226888 File Offset: 0x00224A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x00226898 File Offset: 0x00224A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x002268A8 File Offset: 0x00224AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006464 RID: 25700 RVA: 0x002268B8 File Offset: 0x00224AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006465 RID: 25701 RVA: 0x002268C8 File Offset: 0x00224AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContextCreationEvent other)
		{
		}

		// Token: 0x06006466 RID: 25702 RVA: 0x002268D8 File Offset: 0x00224AD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006467 RID: 25703 RVA: 0x002268E8 File Offset: 0x00224AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006468 RID: 25704 RVA: 0x002268F8 File Offset: 0x00224AF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContextCreationEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					ContextCreationEvent._parser = new MessageParser<ContextCreationEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06006469 RID: 25705 RVA: 0x002269DC File Offset: 0x00224BDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zZMAaYOzCA0ZMfh3G2gQ()
		{
			return true;
		}

		// Token: 0x0600646A RID: 25706 RVA: 0x002269E4 File Offset: 0x00224BE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContextCreationEvent uph9Q3OzDq4KkfwlpdfV()
		{
			return null;
		}

		// Token: 0x04002342 RID: 9026
		private static readonly MessageParser<ContextCreationEvent> _parser;

		// Token: 0x04002343 RID: 9027
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002344 RID: 9028
		public const int ContextFieldNumber = 1;

		// Token: 0x04002345 RID: 9029
		private ContextCreationEvent.Types.GameContext context_;

		// Token: 0x04002346 RID: 9030
		private static ContextCreationEvent ovQckaOz0YZmyKFnLieL;

		// Token: 0x0200080E RID: 2062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600646B RID: 25707 RVA: 0x002D4B58 File Offset: 0x002D2D58
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200080F RID: 2063
			public enum GameContext
			{
				// Token: 0x04002348 RID: 9032
				[OriginalName("ROLE_PLAY")]
				RolePlay,
				// Token: 0x04002349 RID: 9033
				[OriginalName("FIGHT")]
				Fight
			}
		}
	}
}
