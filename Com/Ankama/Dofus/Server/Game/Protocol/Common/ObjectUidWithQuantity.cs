using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B52 RID: 2898
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectUidWithQuantity : IMessage<ObjectUidWithQuantity>, IMessage, IEquatable<ObjectUidWithQuantity>, IDeepCloneable<ObjectUidWithQuantity>, IBufferMessage
	{
		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x06008ABB RID: 35515 RVA: 0x00268814 File Offset: 0x00266A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectUidWithQuantity> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06008ABC RID: 35516 RVA: 0x00268824 File Offset: 0x00266A24
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

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06008ABD RID: 35517 RVA: 0x00268834 File Offset: 0x00266A34
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

		// Token: 0x06008ABE RID: 35518 RVA: 0x00268844 File Offset: 0x00266A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUidWithQuantity()
		{
		}

		// Token: 0x06008ABF RID: 35519 RVA: 0x00268854 File Offset: 0x00266A54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUidWithQuantity(ObjectUidWithQuantity other)
		{
		}

		// Token: 0x06008AC0 RID: 35520 RVA: 0x00268864 File Offset: 0x00266A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUidWithQuantity Clone()
		{
			return null;
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06008AC1 RID: 35521 RVA: 0x00268874 File Offset: 0x00266A74
		// (set) Token: 0x06008AC2 RID: 35522 RVA: 0x00268884 File Offset: 0x00266A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectUid
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

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x06008AC3 RID: 35523 RVA: 0x00268894 File Offset: 0x00266A94
		// (set) Token: 0x06008AC4 RID: 35524 RVA: 0x002688A4 File Offset: 0x00266AA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Quantity
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

		// Token: 0x06008AC5 RID: 35525 RVA: 0x002688B4 File Offset: 0x00266AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008AC6 RID: 35526 RVA: 0x002688C4 File Offset: 0x00266AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectUidWithQuantity other)
		{
			return true;
		}

		// Token: 0x06008AC7 RID: 35527 RVA: 0x002688D4 File Offset: 0x00266AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008AC8 RID: 35528 RVA: 0x002688E4 File Offset: 0x00266AE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008AC9 RID: 35529 RVA: 0x002688F4 File Offset: 0x00266AF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x00268904 File Offset: 0x00266B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008ACB RID: 35531 RVA: 0x00268914 File Offset: 0x00266B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x00268924 File Offset: 0x00266B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectUidWithQuantity other)
		{
		}

		// Token: 0x06008ACD RID: 35533 RVA: 0x00268934 File Offset: 0x00266B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008ACE RID: 35534 RVA: 0x00268944 File Offset: 0x00266B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008ACF RID: 35535 RVA: 0x00268954 File Offset: 0x00266B54
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectUidWithQuantity()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ObjectUidWithQuantity._parser = new MessageParser<ObjectUidWithQuantity>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x00268A20 File Offset: 0x00266C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qGOa3yJdMlWuqkbrJTJi()
		{
			return true;
		}

		// Token: 0x06008AD1 RID: 35537 RVA: 0x00268A28 File Offset: 0x00266C28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectUidWithQuantity X7bB0GJduRWTVnYjbH4h()
		{
			return null;
		}

		// Token: 0x04003320 RID: 13088
		private static readonly MessageParser<ObjectUidWithQuantity> _parser;

		// Token: 0x04003321 RID: 13089
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003322 RID: 13090
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04003323 RID: 13091
		private int objectUid_;

		// Token: 0x04003324 RID: 13092
		public const int QuantityFieldNumber = 2;

		// Token: 0x04003325 RID: 13093
		private int quantity_;

		// Token: 0x04003326 RID: 13094
		internal static ObjectUidWithQuantity LVU0l9JdSYvhpr99wRpp;
	}
}
