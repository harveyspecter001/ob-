using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x02000819 RID: 2073
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EntitiesDispositionEvent : IMessage<EntitiesDispositionEvent>, IMessage, IEquatable<EntitiesDispositionEvent>, IDeepCloneable<EntitiesDispositionEvent>, IBufferMessage
	{
		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x060064D8 RID: 25816 RVA: 0x00227288 File Offset: 0x00225488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntitiesDispositionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x060064D9 RID: 25817 RVA: 0x00227298 File Offset: 0x00225498
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

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x060064DA RID: 25818 RVA: 0x002272A8 File Offset: 0x002254A8
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

		// Token: 0x060064DB RID: 25819 RVA: 0x002272B8 File Offset: 0x002254B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntitiesDispositionEvent()
		{
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x002272C8 File Offset: 0x002254C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntitiesDispositionEvent(EntitiesDispositionEvent other)
		{
		}

		// Token: 0x060064DD RID: 25821 RVA: 0x002272D8 File Offset: 0x002254D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntitiesDispositionEvent Clone()
		{
			return null;
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x060064DE RID: 25822 RVA: 0x002272E8 File Offset: 0x002254E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<EntityDisposition> Dispositions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x002272F8 File Offset: 0x002254F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x00227308 File Offset: 0x00225508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EntitiesDispositionEvent other)
		{
			return true;
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x00227318 File Offset: 0x00225518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x00227328 File Offset: 0x00225528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x00227338 File Offset: 0x00225538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x00227348 File Offset: 0x00225548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x00227358 File Offset: 0x00225558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x00227368 File Offset: 0x00225568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(EntitiesDispositionEvent other)
		{
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x00227378 File Offset: 0x00225578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x00227388 File Offset: 0x00225588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x00227398 File Offset: 0x00225598
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EntitiesDispositionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_AB;
					case 2:
						EntitiesDispositionEvent._parser = new MessageParser<EntitiesDispositionEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						goto IL_73;
					}
					EntitiesDispositionEvent._repeated_dispositions_codec = FieldCodec.ForMessage<EntityDisposition>(10U, hcMLg7AJcIQsCglnEFOC.XVInXhlssT(hcMLg7AJcIQsCglnEFOC.uKtAJUF3ccs));
					num2 = 3;
				}
				IL_73:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 4;
				continue;
				IL_AB:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
			}
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x00227490 File Offset: 0x00225690
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MI3vd0Ozu5yryvt6T3Fs()
		{
			return true;
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x00227498 File Offset: 0x00225698
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EntitiesDispositionEvent JkMt64Oz8Z7HYBrSpDPD()
		{
			return null;
		}

		// Token: 0x04002369 RID: 9065
		private static readonly MessageParser<EntitiesDispositionEvent> _parser;

		// Token: 0x0400236A RID: 9066
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400236B RID: 9067
		public const int DispositionsFieldNumber = 1;

		// Token: 0x0400236C RID: 9068
		private static readonly FieldCodec<EntityDisposition> _repeated_dispositions_codec;

		// Token: 0x0400236D RID: 9069
		private readonly RepeatedField<EntityDisposition> dispositions_;

		// Token: 0x0400236E RID: 9070
		private static EntitiesDispositionEvent D77kQZOzMCPXsItSX0kv;
	}
}
