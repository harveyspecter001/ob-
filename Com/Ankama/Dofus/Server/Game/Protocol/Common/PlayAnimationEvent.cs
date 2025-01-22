using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000BB3 RID: 2995
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayAnimationEvent : IMessage<PlayAnimationEvent>, IMessage, IEquatable<PlayAnimationEvent>, IDeepCloneable<PlayAnimationEvent>, IBufferMessage
	{
		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x0600901A RID: 36890 RVA: 0x0026D0D8 File Offset: 0x0026B2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayAnimationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x0600901B RID: 36891 RVA: 0x0026D0E8 File Offset: 0x0026B2E8
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

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x0600901C RID: 36892 RVA: 0x0026D0F8 File Offset: 0x0026B2F8
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

		// Token: 0x0600901D RID: 36893 RVA: 0x0026D108 File Offset: 0x0026B308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayAnimationEvent()
		{
		}

		// Token: 0x0600901E RID: 36894 RVA: 0x0026D118 File Offset: 0x0026B318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayAnimationEvent(PlayAnimationEvent other)
		{
		}

		// Token: 0x0600901F RID: 36895 RVA: 0x0026D128 File Offset: 0x0026B328
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayAnimationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x06009020 RID: 36896 RVA: 0x0026D138 File Offset: 0x0026B338
		// (set) Token: 0x06009021 RID: 36897 RVA: 0x0026D148 File Offset: 0x0026B348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Animation
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

		// Token: 0x06009022 RID: 36898 RVA: 0x0026D158 File Offset: 0x0026B358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009023 RID: 36899 RVA: 0x0026D168 File Offset: 0x0026B368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlayAnimationEvent other)
		{
			return true;
		}

		// Token: 0x06009024 RID: 36900 RVA: 0x0026D178 File Offset: 0x0026B378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009025 RID: 36901 RVA: 0x0026D188 File Offset: 0x0026B388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009026 RID: 36902 RVA: 0x0026D198 File Offset: 0x0026B398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009027 RID: 36903 RVA: 0x0026D1A8 File Offset: 0x0026B3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009028 RID: 36904 RVA: 0x0026D1B8 File Offset: 0x0026B3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x0026D1C8 File Offset: 0x0026B3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlayAnimationEvent other)
		{
		}

		// Token: 0x0600902A RID: 36906 RVA: 0x0026D1D8 File Offset: 0x0026B3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600902B RID: 36907 RVA: 0x0026D1E8 File Offset: 0x0026B3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x0026D1F8 File Offset: 0x0026B3F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlayAnimationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PlayAnimationEvent._parser = new MessageParser<PlayAnimationEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600902D RID: 36909 RVA: 0x0026D2F0 File Offset: 0x0026B4F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Kgf0HpJ2JId1MBOGyXlA()
		{
			return true;
		}

		// Token: 0x0600902E RID: 36910 RVA: 0x0026D2F8 File Offset: 0x0026B4F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlayAnimationEvent y2mIMdJ2Gw9sGVWK0NEW()
		{
			return null;
		}

		// Token: 0x040035B1 RID: 13745
		private static readonly MessageParser<PlayAnimationEvent> _parser;

		// Token: 0x040035B2 RID: 13746
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035B3 RID: 13747
		public const int AnimationFieldNumber = 1;

		// Token: 0x040035B4 RID: 13748
		private string animation_;

		// Token: 0x040035B5 RID: 13749
		internal static PlayAnimationEvent qhunsBJ2OxhF3w4nJdF9;
	}
}
