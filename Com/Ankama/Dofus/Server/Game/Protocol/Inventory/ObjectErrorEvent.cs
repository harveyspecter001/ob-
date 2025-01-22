using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x0200040B RID: 1035
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectErrorEvent : IMessage<ObjectErrorEvent>, IMessage, IEquatable<ObjectErrorEvent>, IDeepCloneable<ObjectErrorEvent>, IBufferMessage
	{
		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060030DA RID: 12506 RVA: 0x001D449C File Offset: 0x001D269C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060030DB RID: 12507 RVA: 0x001D44AC File Offset: 0x001D26AC
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

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060030DC RID: 12508 RVA: 0x001D44BC File Offset: 0x001D26BC
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

		// Token: 0x060030DD RID: 12509 RVA: 0x001D44CC File Offset: 0x001D26CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectErrorEvent()
		{
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x001D44DC File Offset: 0x001D26DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectErrorEvent(ObjectErrorEvent other)
		{
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x001D44EC File Offset: 0x001D26EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060030E0 RID: 12512 RVA: 0x001D44FC File Offset: 0x001D26FC
		// (set) Token: 0x060030E1 RID: 12513 RVA: 0x001D4510 File Offset: 0x001D2710
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectError Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ObjectError)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x001D4520 File Offset: 0x001D2720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x001D4530 File Offset: 0x001D2730
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectErrorEvent other)
		{
			return true;
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x001D4540 File Offset: 0x001D2740
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x001D4550 File Offset: 0x001D2750
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x001D4560 File Offset: 0x001D2760
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x001D4570 File Offset: 0x001D2770
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x001D4580 File Offset: 0x001D2780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x001D4590 File Offset: 0x001D2790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectErrorEvent other)
		{
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x001D45A0 File Offset: 0x001D27A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x001D45B0 File Offset: 0x001D27B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x001D45C0 File Offset: 0x001D27C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						continue;
					case 4:
						ObjectErrorEvent._parser = new MessageParser<ObjectErrorEvent>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					break;
				}
				IL_97:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
				continue;
				goto IL_97;
			}
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x001D4690 File Offset: 0x001D2890
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sIQoHQOC2huSLwnsCJvg()
		{
			return true;
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x001D4698 File Offset: 0x001D2898
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectErrorEvent LM9Nw0OCEpWxM09r6qon()
		{
			return null;
		}

		// Token: 0x0400111F RID: 4383
		private static readonly MessageParser<ObjectErrorEvent> _parser;

		// Token: 0x04001120 RID: 4384
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001121 RID: 4385
		public const int ReasonFieldNumber = 1;

		// Token: 0x04001122 RID: 4386
		private ObjectError reason_;

		// Token: 0x04001123 RID: 4387
		private static ObjectErrorEvent dqSSqnOC93YvtlvwudIu;
	}
}
