using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element
{
	// Token: 0x02000448 RID: 1096
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StatedMapUpdateEvent : IMessage<StatedMapUpdateEvent>, IMessage, IEquatable<StatedMapUpdateEvent>, IDeepCloneable<StatedMapUpdateEvent>, IBufferMessage
	{
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06003417 RID: 13335 RVA: 0x001D8F64 File Offset: 0x001D7164
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<StatedMapUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06003418 RID: 13336 RVA: 0x001D8F74 File Offset: 0x001D7174
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

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06003419 RID: 13337 RVA: 0x001D8F84 File Offset: 0x001D7184
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

		// Token: 0x0600341A RID: 13338 RVA: 0x001D8F94 File Offset: 0x001D7194
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StatedMapUpdateEvent()
		{
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x001D8FA4 File Offset: 0x001D71A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StatedMapUpdateEvent(StatedMapUpdateEvent other)
		{
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x001D8FB4 File Offset: 0x001D71B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StatedMapUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x0600341D RID: 13341 RVA: 0x001D8FC4 File Offset: 0x001D71C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<StatedElement> StatedElements
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x001D8FD4 File Offset: 0x001D71D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x001D8FE4 File Offset: 0x001D71E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(StatedMapUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x001D8FF4 File Offset: 0x001D71F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x001D9004 File Offset: 0x001D7204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x001D9014 File Offset: 0x001D7214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x001D9024 File Offset: 0x001D7224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x001D9034 File Offset: 0x001D7234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x001D9044 File Offset: 0x001D7244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(StatedMapUpdateEvent other)
		{
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x001D9054 File Offset: 0x001D7254
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x001D9064 File Offset: 0x001D7264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x001D9074 File Offset: 0x001D7274
		[MethodImpl(MethodImplOptions.NoInlining)]
		static StatedMapUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					StatedMapUpdateEvent._repeated_statedElements_codec = FieldCodec.ForMessage<StatedElement>(10U, gBs1iOmmrdoiMMBR3Fcw.XVInXhlssT(gBs1iOmmrdoiMMBR3Fcw.LUKmmVvChuq));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					StatedMapUpdateEvent._parser = new MessageParser<StatedMapUpdateEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
				{
					num2 = 5;
				}
			}
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x001D9190 File Offset: 0x001D7390
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Un1bgSOD7qp0nAm8uWoL()
		{
			return true;
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x001D9198 File Offset: 0x001D7398
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StatedMapUpdateEvent OklDIyODTdKWgtFVutoi()
		{
			return null;
		}

		// Token: 0x0400123A RID: 4666
		private static readonly MessageParser<StatedMapUpdateEvent> _parser;

		// Token: 0x0400123B RID: 4667
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400123C RID: 4668
		public const int StatedElementsFieldNumber = 1;

		// Token: 0x0400123D RID: 4669
		private static readonly FieldCodec<StatedElement> _repeated_statedElements_codec;

		// Token: 0x0400123E RID: 4670
		private readonly RepeatedField<StatedElement> statedElements_;

		// Token: 0x0400123F RID: 4671
		internal static StatedMapUpdateEvent K0hmtxODQObpGYea1y18;
	}
}
