using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008F7 RID: 2295
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateLifePointsEvent : IMessage<UpdateLifePointsEvent>, IMessage, IEquatable<UpdateLifePointsEvent>, IDeepCloneable<UpdateLifePointsEvent>, IBufferMessage
	{
		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06006F9A RID: 28570 RVA: 0x00238E0C File Offset: 0x0023700C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<UpdateLifePointsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06006F9B RID: 28571 RVA: 0x00238E1C File Offset: 0x0023701C
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

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x06006F9C RID: 28572 RVA: 0x00238E2C File Offset: 0x0023702C
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

		// Token: 0x06006F9D RID: 28573 RVA: 0x00238E3C File Offset: 0x0023703C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UpdateLifePointsEvent()
		{
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x00238E4C File Offset: 0x0023704C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UpdateLifePointsEvent(UpdateLifePointsEvent other)
		{
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x00238E5C File Offset: 0x0023705C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UpdateLifePointsEvent Clone()
		{
			return null;
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06006FA0 RID: 28576 RVA: 0x00238E6C File Offset: 0x0023706C
		// (set) Token: 0x06006FA1 RID: 28577 RVA: 0x00238E7C File Offset: 0x0023707C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int LifePoints
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

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06006FA2 RID: 28578 RVA: 0x00238E8C File Offset: 0x0023708C
		// (set) Token: 0x06006FA3 RID: 28579 RVA: 0x00238E9C File Offset: 0x0023709C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxLifePoints
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

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06006FA4 RID: 28580 RVA: 0x00238EAC File Offset: 0x002370AC
		// (set) Token: 0x06006FA5 RID: 28581 RVA: 0x00238EBC File Offset: 0x002370BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int LifePointsGained
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

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06006FA6 RID: 28582 RVA: 0x00238ECC File Offset: 0x002370CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLifePointsGained
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06006FA7 RID: 28583 RVA: 0x00238EDC File Offset: 0x002370DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearLifePointsGained()
		{
		}

		// Token: 0x06006FA8 RID: 28584 RVA: 0x00238EEC File Offset: 0x002370EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006FA9 RID: 28585 RVA: 0x00238EFC File Offset: 0x002370FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(UpdateLifePointsEvent other)
		{
			return true;
		}

		// Token: 0x06006FAA RID: 28586 RVA: 0x00238F0C File Offset: 0x0023710C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006FAB RID: 28587 RVA: 0x00238F1C File Offset: 0x0023711C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006FAC RID: 28588 RVA: 0x00238F2C File Offset: 0x0023712C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006FAD RID: 28589 RVA: 0x00238F3C File Offset: 0x0023713C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006FAE RID: 28590 RVA: 0x00238F4C File Offset: 0x0023714C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006FAF RID: 28591 RVA: 0x00238F5C File Offset: 0x0023715C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(UpdateLifePointsEvent other)
		{
		}

		// Token: 0x06006FB0 RID: 28592 RVA: 0x00238F6C File Offset: 0x0023716C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006FB1 RID: 28593 RVA: 0x00238F7C File Offset: 0x0023717C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006FB2 RID: 28594 RVA: 0x00238F8C File Offset: 0x0023718C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UpdateLifePointsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UpdateLifePointsEvent._parser = new MessageParser<UpdateLifePointsEvent>(() => null);
					num2 = 2;
					continue;
				case 2:
					UpdateLifePointsEvent.LifePointsGainedDefaultValue = 0;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				break;
			}
		}

		// Token: 0x06006FB3 RID: 28595 RVA: 0x0023906C File Offset: 0x0023726C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tSYh5dJBhFBHiApoEvr3()
		{
			return true;
		}

		// Token: 0x06006FB4 RID: 28596 RVA: 0x00239074 File Offset: 0x00237274
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static UpdateLifePointsEvent tV1ZmUJBrJTtHMqStUUJ()
		{
			return null;
		}

		// Token: 0x04002710 RID: 10000
		private static readonly MessageParser<UpdateLifePointsEvent> _parser;

		// Token: 0x04002711 RID: 10001
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002712 RID: 10002
		private int _hasBits0;

		// Token: 0x04002713 RID: 10003
		public const int LifePointsFieldNumber = 1;

		// Token: 0x04002714 RID: 10004
		private int lifePoints_;

		// Token: 0x04002715 RID: 10005
		public const int MaxLifePointsFieldNumber = 2;

		// Token: 0x04002716 RID: 10006
		private int maxLifePoints_;

		// Token: 0x04002717 RID: 10007
		public const int LifePointsGainedFieldNumber = 3;

		// Token: 0x04002718 RID: 10008
		private static readonly int LifePointsGainedDefaultValue;

		// Token: 0x04002719 RID: 10009
		private int lifePointsGained_;

		// Token: 0x0400271A RID: 10010
		internal static UpdateLifePointsEvent rTO4AeJBWvKatWE5WulA;
	}
}
