using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BFA RID: 3066
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BakShopTokenEvent : IMessage<BakShopTokenEvent>, IMessage, IEquatable<BakShopTokenEvent>, IDeepCloneable<BakShopTokenEvent>, IBufferMessage
	{
		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x0600937C RID: 37756 RVA: 0x0027306C File Offset: 0x0027126C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BakShopTokenEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x0600937D RID: 37757 RVA: 0x0027307C File Offset: 0x0027127C
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

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x0600937E RID: 37758 RVA: 0x0027308C File Offset: 0x0027128C
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

		// Token: 0x0600937F RID: 37759 RVA: 0x0027309C File Offset: 0x0027129C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakShopTokenEvent()
		{
		}

		// Token: 0x06009380 RID: 37760 RVA: 0x002730AC File Offset: 0x002712AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakShopTokenEvent(BakShopTokenEvent other)
		{
		}

		// Token: 0x06009381 RID: 37761 RVA: 0x002730BC File Offset: 0x002712BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakShopTokenEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06009382 RID: 37762 RVA: 0x002730CC File Offset: 0x002712CC
		// (set) Token: 0x06009383 RID: 37763 RVA: 0x002730DC File Offset: 0x002712DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Token
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

		// Token: 0x06009384 RID: 37764 RVA: 0x002730EC File Offset: 0x002712EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009385 RID: 37765 RVA: 0x002730FC File Offset: 0x002712FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BakShopTokenEvent other)
		{
			return true;
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x0027310C File Offset: 0x0027130C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x0027311C File Offset: 0x0027131C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009388 RID: 37768 RVA: 0x0027312C File Offset: 0x0027132C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009389 RID: 37769 RVA: 0x0027313C File Offset: 0x0027133C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600938A RID: 37770 RVA: 0x0027314C File Offset: 0x0027134C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x0027315C File Offset: 0x0027135C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BakShopTokenEvent other)
		{
		}

		// Token: 0x0600938C RID: 37772 RVA: 0x0027316C File Offset: 0x0027136C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600938D RID: 37773 RVA: 0x0027317C File Offset: 0x0027137C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600938E RID: 37774 RVA: 0x0027318C File Offset: 0x0027138C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BakShopTokenEvent()
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
						BakShopTokenEvent._parser = new MessageParser<BakShopTokenEvent>(() => null);
						num2 = 2;
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_AC;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 != 0)
					{
						num2 = 1;
					}
				}
				IL_AC:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x0600938F RID: 37775 RVA: 0x0027325C File Offset: 0x0027145C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tgj1MUJEHFTZ7yion7hr()
		{
			return true;
		}

		// Token: 0x06009390 RID: 37776 RVA: 0x00273264 File Offset: 0x00271464
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BakShopTokenEvent I0rgL3JEYgewypNAX3rE()
		{
			return null;
		}

		// Token: 0x040036E6 RID: 14054
		private static readonly MessageParser<BakShopTokenEvent> _parser;

		// Token: 0x040036E7 RID: 14055
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036E8 RID: 14056
		public const int TokenFieldNumber = 1;

		// Token: 0x040036E9 RID: 14057
		private string token_;

		// Token: 0x040036EA RID: 14058
		internal static BakShopTokenEvent qBxw6xJEpXtPq7D2XjM6;
	}
}
