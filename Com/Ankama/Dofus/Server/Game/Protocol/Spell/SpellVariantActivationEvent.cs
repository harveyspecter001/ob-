using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell
{
	// Token: 0x0200011E RID: 286
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpellVariantActivationEvent : IMessage<SpellVariantActivationEvent>, IMessage, IEquatable<SpellVariantActivationEvent>, IDeepCloneable<SpellVariantActivationEvent>, IBufferMessage
	{
		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00198D18 File Offset: 0x00196F18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SpellVariantActivationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00198D28 File Offset: 0x00196F28
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

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00198D38 File Offset: 0x00196F38
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

		// Token: 0x06000D0C RID: 3340 RVA: 0x00198D48 File Offset: 0x00196F48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellVariantActivationEvent()
		{
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00198D58 File Offset: 0x00196F58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellVariantActivationEvent(SpellVariantActivationEvent other)
		{
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00198D68 File Offset: 0x00196F68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellVariantActivationEvent Clone()
		{
			return null;
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00198D78 File Offset: 0x00196F78
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00198D88 File Offset: 0x00196F88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SpellId
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

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x00198D98 File Offset: 0x00196F98
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x00198DA8 File Offset: 0x00196FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Effective
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00198DB8 File Offset: 0x00196FB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00198DC8 File Offset: 0x00196FC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SpellVariantActivationEvent other)
		{
			return true;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00198DD8 File Offset: 0x00196FD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00198DE8 File Offset: 0x00196FE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00198DF8 File Offset: 0x00196FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00198E08 File Offset: 0x00197008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00198E18 File Offset: 0x00197018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00198E28 File Offset: 0x00197028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SpellVariantActivationEvent other)
		{
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00198E38 File Offset: 0x00197038
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00198E48 File Offset: 0x00197048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00198E58 File Offset: 0x00197058
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SpellVariantActivationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					SpellVariantActivationEvent._parser = new MessageParser<SpellVariantActivationEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00198F24 File Offset: 0x00197124
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TILX5bOcUdAKhyZCHkTQ()
		{
			return true;
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00198F2C File Offset: 0x0019712C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SpellVariantActivationEvent zB0gUwOcvHOBLJ5uTyps()
		{
			return null;
		}

		// Token: 0x040004BB RID: 1211
		private static readonly MessageParser<SpellVariantActivationEvent> _parser;

		// Token: 0x040004BC RID: 1212
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004BD RID: 1213
		public const int SpellIdFieldNumber = 1;

		// Token: 0x040004BE RID: 1214
		private int spellId_;

		// Token: 0x040004BF RID: 1215
		public const int EffectiveFieldNumber = 2;

		// Token: 0x040004C0 RID: 1216
		private bool effective_;

		// Token: 0x040004C1 RID: 1217
		internal static SpellVariantActivationEvent L7gjD5OccrlHGmTj08C4;
	}
}
