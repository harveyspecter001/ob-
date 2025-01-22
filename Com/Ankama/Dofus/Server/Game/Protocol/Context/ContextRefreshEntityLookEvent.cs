using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x02000817 RID: 2071
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContextRefreshEntityLookEvent : IMessage<ContextRefreshEntityLookEvent>, IMessage, IEquatable<ContextRefreshEntityLookEvent>, IDeepCloneable<ContextRefreshEntityLookEvent>, IBufferMessage
	{
		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x060064BC RID: 25788 RVA: 0x00227054 File Offset: 0x00225254
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ContextRefreshEntityLookEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x060064BD RID: 25789 RVA: 0x00227064 File Offset: 0x00225264
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

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x060064BE RID: 25790 RVA: 0x00227074 File Offset: 0x00225274
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

		// Token: 0x060064BF RID: 25791 RVA: 0x00227084 File Offset: 0x00225284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextRefreshEntityLookEvent()
		{
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x00227094 File Offset: 0x00225294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextRefreshEntityLookEvent(ContextRefreshEntityLookEvent other)
		{
		}

		// Token: 0x060064C1 RID: 25793 RVA: 0x002270A4 File Offset: 0x002252A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextRefreshEntityLookEvent Clone()
		{
			return null;
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x060064C2 RID: 25794 RVA: 0x002270B4 File Offset: 0x002252B4
		// (set) Token: 0x060064C3 RID: 25795 RVA: 0x002270C4 File Offset: 0x002252C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
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

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x060064C4 RID: 25796 RVA: 0x002270D4 File Offset: 0x002252D4
		// (set) Token: 0x060064C5 RID: 25797 RVA: 0x002270E4 File Offset: 0x002252E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLook Look
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

		// Token: 0x060064C6 RID: 25798 RVA: 0x002270F4 File Offset: 0x002252F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x00227104 File Offset: 0x00225304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContextRefreshEntityLookEvent other)
		{
			return true;
		}

		// Token: 0x060064C8 RID: 25800 RVA: 0x00227114 File Offset: 0x00225314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060064C9 RID: 25801 RVA: 0x00227124 File Offset: 0x00225324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060064CA RID: 25802 RVA: 0x00227134 File Offset: 0x00225334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x00227144 File Offset: 0x00225344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060064CC RID: 25804 RVA: 0x00227154 File Offset: 0x00225354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060064CD RID: 25805 RVA: 0x00227164 File Offset: 0x00225364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContextRefreshEntityLookEvent other)
		{
		}

		// Token: 0x060064CE RID: 25806 RVA: 0x00227174 File Offset: 0x00225374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060064CF RID: 25807 RVA: 0x00227184 File Offset: 0x00225384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060064D0 RID: 25808 RVA: 0x00227194 File Offset: 0x00225394
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContextRefreshEntityLookEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ContextRefreshEntityLookEvent._parser = new MessageParser<ContextRefreshEntityLookEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 1;
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

		// Token: 0x060064D1 RID: 25809 RVA: 0x00227278 File Offset: 0x00225478
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gE9x75OzPUuXHlYIZMin()
		{
			return true;
		}

		// Token: 0x060064D2 RID: 25810 RVA: 0x00227280 File Offset: 0x00225480
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContextRefreshEntityLookEvent onukCGOzShYI12RbUCJO()
		{
			return null;
		}

		// Token: 0x04002360 RID: 9056
		private static readonly MessageParser<ContextRefreshEntityLookEvent> _parser;

		// Token: 0x04002361 RID: 9057
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002362 RID: 9058
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04002363 RID: 9059
		private long entityId_;

		// Token: 0x04002364 RID: 9060
		public const int LookFieldNumber = 2;

		// Token: 0x04002365 RID: 9061
		private EntityLook look_;

		// Token: 0x04002366 RID: 9062
		internal static ContextRefreshEntityLookEvent FAbyI5Ozi43kQLkPASxb;
	}
}
