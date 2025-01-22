using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x0200049B RID: 1179
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagEditFinishedEvent : IMessage<HavenBagEditFinishedEvent>, IMessage, IEquatable<HavenBagEditFinishedEvent>, IDeepCloneable<HavenBagEditFinishedEvent>, IBufferMessage
	{
		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x001E05C8 File Offset: 0x001DE7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagEditFinishedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06003866 RID: 14438 RVA: 0x001E05D8 File Offset: 0x001DE7D8
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

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x001E05E8 File Offset: 0x001DE7E8
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

		// Token: 0x06003868 RID: 14440 RVA: 0x001E05F8 File Offset: 0x001DE7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEditFinishedEvent()
		{
		}

		// Token: 0x06003869 RID: 14441 RVA: 0x001E0608 File Offset: 0x001DE808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEditFinishedEvent(HavenBagEditFinishedEvent other)
		{
		}

		// Token: 0x0600386A RID: 14442 RVA: 0x001E0618 File Offset: 0x001DE818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEditFinishedEvent Clone()
		{
			return null;
		}

		// Token: 0x0600386B RID: 14443 RVA: 0x001E0628 File Offset: 0x001DE828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600386C RID: 14444 RVA: 0x001E0638 File Offset: 0x001DE838
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagEditFinishedEvent other)
		{
			return true;
		}

		// Token: 0x0600386D RID: 14445 RVA: 0x001E0648 File Offset: 0x001DE848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x001E0658 File Offset: 0x001DE858
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x001E0668 File Offset: 0x001DE868
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x001E0678 File Offset: 0x001DE878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x001E0688 File Offset: 0x001DE888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x001E0698 File Offset: 0x001DE898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagEditFinishedEvent other)
		{
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x001E06A8 File Offset: 0x001DE8A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003874 RID: 14452 RVA: 0x001E06B8 File Offset: 0x001DE8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x001E06C8 File Offset: 0x001DE8C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagEditFinishedEvent()
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
						goto IL_49;
					case 2:
						HavenBagEditFinishedEvent._parser = new MessageParser<HavenBagEditFinishedEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					}
					return;
				}
				IL_49:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
			}
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x001E0798 File Offset: 0x001DE998
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M9fP08OwVlpeWwyS9OOW()
		{
			return true;
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x001E07A0 File Offset: 0x001DE9A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagEditFinishedEvent D2NFDUOw0MVrsM3J7foS()
		{
			return null;
		}

		// Token: 0x040013B0 RID: 5040
		private static readonly MessageParser<HavenBagEditFinishedEvent> _parser;

		// Token: 0x040013B1 RID: 5041
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013B2 RID: 5042
		internal static HavenBagEditFinishedEvent hTNoMwOwrlAOnaWnry1Z;
	}
}
