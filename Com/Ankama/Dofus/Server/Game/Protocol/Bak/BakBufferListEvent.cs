using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BE0 RID: 3040
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BakBufferListEvent : IMessage<BakBufferListEvent>, IMessage, IEquatable<BakBufferListEvent>, IDeepCloneable<BakBufferListEvent>, IBufferMessage
	{
		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x0600924D RID: 37453 RVA: 0x00271904 File Offset: 0x0026FB04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BakBufferListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x0600924E RID: 37454 RVA: 0x00271914 File Offset: 0x0026FB14
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

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x0600924F RID: 37455 RVA: 0x00271924 File Offset: 0x0026FB24
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

		// Token: 0x06009250 RID: 37456 RVA: 0x00271934 File Offset: 0x0026FB34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakBufferListEvent()
		{
		}

		// Token: 0x06009251 RID: 37457 RVA: 0x00271944 File Offset: 0x0026FB44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakBufferListEvent(BakBufferListEvent other)
		{
		}

		// Token: 0x06009252 RID: 37458 RVA: 0x00271954 File Offset: 0x0026FB54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakBufferListEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06009253 RID: 37459 RVA: 0x00271964 File Offset: 0x0026FB64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<BufferInformation> Buffers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06009254 RID: 37460 RVA: 0x00271974 File Offset: 0x0026FB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009255 RID: 37461 RVA: 0x00271984 File Offset: 0x0026FB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BakBufferListEvent other)
		{
			return true;
		}

		// Token: 0x06009256 RID: 37462 RVA: 0x00271994 File Offset: 0x0026FB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009257 RID: 37463 RVA: 0x002719A4 File Offset: 0x0026FBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009258 RID: 37464 RVA: 0x002719B4 File Offset: 0x0026FBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009259 RID: 37465 RVA: 0x002719C4 File Offset: 0x0026FBC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600925A RID: 37466 RVA: 0x002719D4 File Offset: 0x0026FBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600925B RID: 37467 RVA: 0x002719E4 File Offset: 0x0026FBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BakBufferListEvent other)
		{
		}

		// Token: 0x0600925C RID: 37468 RVA: 0x002719F4 File Offset: 0x0026FBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600925D RID: 37469 RVA: 0x00271A04 File Offset: 0x0026FC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600925E RID: 37470 RVA: 0x00271A14 File Offset: 0x0026FC14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BakBufferListEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						goto IL_8B;
					case 5:
						BakBufferListEvent._repeated_buffers_codec = FieldCodec.ForMessage<BufferInformation>(10U, KLBa77elutUBfi00IJDk.XVInXhlssT(KLBa77elutUBfi00IJDk.DyBel8doBb3));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_8B:
				BakBufferListEvent._parser = new MessageParser<BakBufferListEvent>(() => null);
				num = 5;
			}
		}

		// Token: 0x0600925F RID: 37471 RVA: 0x00271B34 File Offset: 0x0026FD34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XUyrLfJEEaCZIt1HMnsa()
		{
			return true;
		}

		// Token: 0x06009260 RID: 37472 RVA: 0x00271B3C File Offset: 0x0026FD3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BakBufferListEvent DBRL3FJEX191HZy50xsx()
		{
			return null;
		}

		// Token: 0x04003679 RID: 13945
		private static readonly MessageParser<BakBufferListEvent> _parser;

		// Token: 0x0400367A RID: 13946
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400367B RID: 13947
		public const int BuffersFieldNumber = 1;

		// Token: 0x0400367C RID: 13948
		private static readonly FieldCodec<BufferInformation> _repeated_buffers_codec;

		// Token: 0x0400367D RID: 13949
		private readonly RepeatedField<BufferInformation> buffers_;

		// Token: 0x0400367E RID: 13950
		internal static BakBufferListEvent ULLixYJE2iwavcUGwntm;
	}
}
